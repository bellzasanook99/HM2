using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace Core.Database.DAL
{
    public class CRUDPortal
    {
        public static string DBConn { get; set; }

        public CRUDPortal()
        {
            renew();
        }

        Invoke _invoke;
        public Invoke invoke
        {
            get
            {
                return _invoke;
            }
        }

        public void renew()
        {
            // var str = ConfigurationManager.AppSettings["Production"];
            try
            {
                var connection = ConfigurationManager.ConnectionStrings["Production"].ConnectionString;
                this._invoke = new Invoke(ConfigurationManager.ConnectionStrings["Production"].ConnectionString);
            }
            catch (Exception ex)
            {
                var connection = DBConn;
                this._invoke = new Invoke(DBConn);
            }

        }


        public void renew(string connectionName)
        {
            try
            {
                string dbConn = "";
                try
                {
                    dbConn = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
                }
                catch (Exception ee)
                {
                    dbConn = connectionName;
                }
                if (string.IsNullOrEmpty(dbConn))
                {
                    dbConn = connectionName;
                }
                this._invoke = new Invoke(dbConn);
            }
            catch (Exception ex)
            {
                this._invoke = new Invoke(DBConn);
            }


        }
    }

    [ComVisible(true)]
    public class Invoke
    {
        #region LocalParameter

        string _connectionString = "";
        List<KeyValuePair<string, dynamic>> _parameters;
        string _nullVal = "[force-null]";
        public string NullValue
        {
            get
            {
                return _nullVal;
            }
        }

        public List<KeyValuePair<string, dynamic>> parameters
        {
            get
            {
                return _parameters;
            }
            set
            {
                _parameters = value;
            }
        }

        public void AddParameter(string key, dynamic value)
        {
            parameters.Add(new KeyValuePair<string, dynamic>("@" + key, value));

        }

        List<InsertMod> _Insert;
        List<UpdateMod> _Update;
        List<KeyValuePair<string, string>> _delete;
        List<QueryParameter> _execute;
        int _pageSize = 20;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = value;
            }
        }
        #endregion

        public string ConnectionString { get { return _connectionString; } set { _connectionString = value; } }
        //public class parameter
        //{
        //    void Add(string name, dynamic value)
        //    {
        //        _parameters.Add(new KeyValuePair<string, dynamic>(name, value));
        //    }
        //}
        public Invoke(string connectionStringName)
        {
            _parameters = new List<KeyValuePair<string, dynamic>>();
            _connectionString = connectionStringName;
            _Insert = new List<InsertMod>();
            _Update = new List<UpdateMod>();
            _delete = new List<KeyValuePair<string, string>>();
            _execute = new List<QueryParameter>();
        }
        public Invoke()
        {
            _parameters = new List<KeyValuePair<string, dynamic>>();
            _Insert = new List<InsertMod>();
            _Update = new List<UpdateMod>();
            _delete = new List<KeyValuePair<string, string>>();
            _execute = new List<QueryParameter>();
        }
        /// <summary>
        /// Becareful parameter name have to unix if you passed
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <returns></returns>
        public List<T> GetList<T>(string query)
        {
            return Get<T>(query, null);
        }

        public T Get<T>(string query)
        {
            return Get<T>(query, null).FirstOrDefault();
        }

        public List<TReturn> GetMap<TFirst, TSecond, TReturn>(string query, Func<TFirst, TSecond, TReturn> map)
        {
            string sql = query;
            List<TReturn> mod = new List<TReturn>();
            using (var conn = new SqlConnection(_connectionString))
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                DynamicParameters vals = new DynamicParameters();

                if (_parameters.Count > 0)
                {
                    foreach (var item in _parameters)
                    {
                        vals.Add("@" + item.Key, item.Value);
                        sql = sql.Replace(item.Key, "@" + item.Key);
                    }
                }
                var obj = conn.Query<TFirst, TSecond, TReturn>(sql, map, vals).ToList();
                if (obj.Count > 0)
                    mod = obj;
                else mod = new List<TReturn>();
                conn.Close();
            }
            return mod;
        }

        public List<T> Get<T>(string query, int? pageNum)
        {
            try
            {
                string sql = query;
                List<T> mod = new List<T>();
                using (var conn = new SqlConnection(_connectionString))
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                    conn.Open();

                    DynamicParameters vals = new DynamicParameters();

                    if (_parameters.Count > 0)
                    {
                        foreach (var item in _parameters)
                        {
                            vals.Add(item.Key, item.Value);
                            //sql = sql.Replace(item.Key, "@" + item.Key);
                        }
                    }
                    if (pageNum != null)
                    {
                        sql = string.Format(@"select * from (
select rownum as num, a.* from ( {0} ) a
) k
where num > {1} and num <={2}", sql, (PageSize * pageNum), (PageSize * pageNum) + PageSize);

                    }
                    var obj = conn.Query<T>(sql, vals).ToList();
                    if (obj.Count > 0)
                        mod = obj;
                    else mod = new List<T>();

                    this.ClearParam();
                    conn.Close();
                }
                return mod;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<T> ListByPage<T>(string query, int? pageNum, string order_by)
        {
            string sql = query;
            List<T> mod = new List<T>();
            using (var conn = new SqlConnection(_connectionString))
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();

                DynamicParameters vals = new DynamicParameters();

                if (_parameters.Count > 0)
                {
                    foreach (var item in _parameters)
                    {
                        vals.Add("@" + item.Key, item.Value);
                        sql = sql.Replace(item.Key, "@" + item.Key);
                    }
                }
                if (pageNum != null)
                {
                    sql = string.Format(@"select *  from (
                                        {0} 
                                        ) a
                                        order by {3}
                                        OFFSET {1} ROWS
                                        FETCH NEXT {2} ROWS ONLY
                                         ", sql,
                                        (PageSize * pageNum),
                                        (PageSize * pageNum) + PageSize,
                                        order_by
                                        );

                }
                var obj = conn.Query<T>(sql, vals).ToList();
                if (obj.Count > 0)
                    mod = obj;
                else mod = new List<T>();
                conn.Close();
            }
            return mod;
        }

        /// <summary>
        /// Improve more paging Data
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <returns></returns>
        public KeyValuePair<int, List<T>> GetRowWithNum<T>(string query)
        {
            try
            {
                string sql = query;
                KeyValuePair<int, List<T>> mod = new KeyValuePair<int, List<T>>();
                using (var conn = new SqlConnection(_connectionString))
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                    conn.Open();

                    DynamicParameters vals = new DynamicParameters();
                    string condition = "";
                    if (_parameters.Count > 0)
                    {
                        foreach (var item in _parameters)
                        {
                            vals.Add("@" + item.Key, item.Value);
                            sql = sql.Replace(item.Key, "@" + item.Key);
                        }
                    }
                    if (sql.ToLower().Contains("where"))
                    {
                        condition = sql.Substring(sql.ToLower().IndexOf("where") - 1);
                        if (condition.ToLower().Contains("order"))
                        {
                            condition = condition.Substring(0, condition.ToLower().IndexOf("order"));
                        }
                    }
                    var from = sql.ToLower().IndexOf("from") + 4;
                    var to = sql.ToUpper().IndexOf("ORDER BY");
                    if (sql.ToLower().IndexOf("where") > -1)
                    {
                        var tempWhere = sql.ToLower().IndexOf("where");
                        if (tempWhere > from)
                            to = tempWhere;
                    }
                    string sqlfrom = sql.Substring(from, to - from);
                    string fullSql = $"select count(*) from {sqlfrom} {condition}" + @"
 " + sql;
                    var obj = conn.QueryMultiple(fullSql, vals);
                    mod = new KeyValuePair<int, List<T>>(obj.Read<int>().Single(), obj.Read<T>().ToList());
                    ////if (obj.Count > 0)
                    ////    mod = obj;
                    //else mod = new List<T>();
                    conn.Close();
                }
                return mod;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<object> Get(string query, int? pageNum)
        {
            try
            {
                string sql = query;
                List<object> mod = new List<object>();
                using (var conn = new SqlConnection(_connectionString))
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                    conn.Open();

                    DynamicParameters vals = new DynamicParameters();

                    if (_parameters.Count > 0)
                    {
                        foreach (var item in _parameters)
                        {
                            vals.Add("@" + item.Key, item.Value);
                            sql = sql.Replace(item.Key, "@" + item.Key);
                        }
                    }
                    if (pageNum != null)
                    {
                        sql = string.Format(@"select * from (
select rownum as num, a.* from ( {0} ) a
) k
where num > {1} and num <={2}", sql, (PageSize * pageNum), (PageSize * pageNum) + PageSize);

                    }
                    var obj = conn.Query(sql, vals).ToList();
                    if (obj.Count > 0)
                        mod = obj;
                    //else mod = new List<T>();
                    conn.Close();
                }
                return mod;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public T ExecuteReturning<T>(string query, string returnParam)
        {
            try
            {
                string sql = query;
                //T mod =;//= new T();// = new T();
                using (var conn = new SqlConnection(_connectionString))
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                    conn.Open();

                    DynamicParameters vals = new DynamicParameters();

                    if (_parameters.Count > 0)
                    {
                        foreach (var item in _parameters)
                        {
                            vals.Add("@" + item.Key, item.Value);
                            sql = sql.Replace(item.Key, "@" + item.Key);
                        }
                    }
                    //vals.Add("@" + returnParam, dbType: DbType.Int32, direction: ParameterDirection.Output);
                    //sql = sql.Replace(returnParam, "@" + returnParam);
                    ///var id = connection.Query<int>(sql, new { Stuff = mystuff}).Single();
                    //T obj = conn.Query<T>(sql, vals).Single();
                    //T obj = conn.ExecuteScalar<T>(sql, vals);
                    //conn.Execute(sql, vals);
                    T obj = conn.Query<T>(sql, vals).Single();
                    //var data = vals.Get<T>(returnParam);
                    //if (obj != null)
                    //    mod = obj;
                    //else mod = new List<T>();
                    conn.Close();
                    //return obj;
                    return obj;
                }
                //return mod;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ClearParam()
        {
            _parameters.Clear();
            _parameters = new List<KeyValuePair<string, dynamic>>();
        }

        public void Add(dynamic mod)
        {
            Add(mod, mod.GetType().Name);

        }
        public void Add(dynamic mod, string targetTable)
        {
            var obj = new InsertMod();
            obj.TableName = targetTable;
            obj.Field = new List<KeyValuePair<string, dynamic>>();
            foreach (System.Reflection.PropertyInfo prop in mod.GetType().GetProperties())
            {
                if (prop.GetValue(mod, null) == null)
                    continue;
                //if (prop.GetValue(mod, null).ToString() == "[force-null]")
                //    obj.Field.Add(new KeyValuePair<string, dynamic>(prop.Name, null));
                //else
                obj.Field.Add(new KeyValuePair<string, dynamic>(prop.Name, prop.GetValue(mod, null)));

            }
            _Insert.Add(obj);

        }
        public void Update(dynamic mod, string criteria)
        {
            Update(mod, criteria, mod.GetType().Name);
        }
        public void Update(dynamic mod, string criteria, string targetTable)
        {
            var obj = new UpdateMod();
            obj.TableName = targetTable;
            obj.Field = new List<KeyValuePair<string, dynamic>>();
            obj.ShortCriteria = criteria;
            foreach (System.Reflection.PropertyInfo prop in mod.GetType().GetProperties())
            {
                if (prop.GetValue(mod, null) == null)
                    continue;
                if (prop.GetValue(mod, null).ToString() == "")
                    continue;

                //if (prop.GetValue(mod, null).ToString() == NullValue)
                //    obj.Field.Add(new KeyValuePair<string, dynamic>(prop.Name, null));
                //else
                obj.Field.Add(new KeyValuePair<string, dynamic>(prop.Name, prop.GetValue(mod, null)));
            }
            _Update.Add(obj);
        }
        public void Remove(string Table, string criteria)
        {
            _delete.Add(new KeyValuePair<string, string>(Table, criteria));
        }
        public void Execute(string sql)
        {
            var param = new List<KeyValuePair<string, dynamic>>();
            parameters.ForEach(x => param.Add(x));
            _execute.Add(new QueryParameter { Query = sql, Parameter = param });
            this.ClearParam();
        }


        public void MergeExecute(Invoke invoke)
        {

            foreach (var item in invoke._delete)
            {
                _delete.Add(item);
            }

            foreach (var item in invoke._Insert)
            {
                _Insert.Add(item);
            }

            foreach (var item in invoke._execute)
            {
                _execute.Add(item);
            }

            foreach (var item in invoke._Update)
            {
                _Update.Add(item);
            }


        }

        public void Commit()
        {
            string[] reserved = { ".NEXTVAL", ".CURRVAL", "SYSDATE" };
            using (var conn = new SqlConnection(_connectionString))
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();

                bool isUpdate = false;
                IDbTransaction transaction = conn.BeginTransaction();
                //Delete
                foreach (var item in _delete)
                {
                    string genSql = "Delete " + item.Key + "  ";
                    if (!string.IsNullOrEmpty(item.Value))
                        genSql += " where " + item.Value;
                    conn.Execute(genSql, null, transaction);
                    isUpdate = true;
                }
                _delete.Clear();
                //Insert Section
                foreach (var item in _Insert)
                {
                    string genSql = "INSERT INTO " + item.TableName.ToLower().Replace("viewmodel", "") + " ( ";
                    string values = @" VALUES  ( ";
                    DynamicParameters vals = new DynamicParameters();
                    int i = 0;
                    foreach (KeyValuePair<string, dynamic> obj in item.Field)
                    {
                        if (obj.Value == null)
                            continue;

                        //if (field.InnerText.ToUpper().Contains(".NEXTVAL") || field.InnerText.ToUpper().Contains(".CURRVAL")
                        //       || field.InnerText.ToUpper().Contains("SYSDATE") || field.InnerText.ToUpper() == "NULL")
                        //{
                        //    val += field.InnerText + ",";

                        //}
                        genSql += obj.Key + ",";
                        if (reserved.Where(a => obj.Value.ToString().Contains(a)).Count() > 0)
                        {
                            values += obj.Value.ToString() + ",";
                        }
                        else if (obj.Value.ToString() == NullValue)
                        {
                            values += "null,";
                        }
                        else if (obj.Value.ToString().ToLower() == "sysdate")
                        {
                            string paramname = "GETDATE()";
                            values += paramname + ",";
                        }
                        else
                        {
                            string paramname = "@a" + (i++).ToString();
                            values += paramname + ",";
                            vals.Add(paramname, obj.Value);
                        }

                    }
                    genSql = genSql.Remove(genSql.Length - 1);
                    values = values.Remove(values.Length - 1);
                    genSql += " ) ";
                    values += " ) ";
                    conn.Execute(genSql + values, vals, transaction);
                    isUpdate = true;
                }
                _Insert.Clear();
                //Update Section
                foreach (var item in _Update)
                {
                    string genSql = "UPDATE " + item.TableName.ToLower().Replace("viewmodel", "") + "  ";
                    string values = @" set  ";
                    DynamicParameters vals = new DynamicParameters();
                    int i = 0;
                    foreach (KeyValuePair<string, dynamic> obj in item.Field)
                    {
                        if (obj.Value == null)
                            continue;
                        if (reserved.Where(a => obj.Value.ToString().Contains(a)).Count() > 0)
                        {
                            values += string.Format("{0}={1},", obj.Key, obj.Value.ToString());
                        }
                        else if (obj.Value.ToString() == NullValue)
                        {
                            values += string.Format("{0}=null,", obj.Key);
                            //values += "null,";
                        }
                        else
                        {
                            string paramname = "@a" + (i++).ToString();
                            //genSql +=  + ",";
                            values += string.Format("{0}={1},", obj.Key, paramname);
                            vals.Add(paramname, obj.Value);
                        }



                    }
                    genSql = genSql.Remove(genSql.Length - 1);
                    values = values.Remove(values.Length - 1);
                    if (item.ShortCriteria != "")
                        values += " where  " + item.ShortCriteria;
                    conn.Execute(genSql + values, vals, transaction);
                    isUpdate = true;
                }
                _Update.Clear();

                foreach (var item in _execute)
                {
                    DynamicParameters vals = new DynamicParameters();
                    string sqlEx = item.Query;
                    foreach (KeyValuePair<string, dynamic> obj in item.Parameter)
                    {
                        vals.Add(obj.Key, obj.Value);
                    }
                    conn.Execute(sqlEx, vals, transaction);
                    isUpdate = true;
                }
                _execute.Clear();
                try
                {
                    if (isUpdate)
                        transaction.Commit();
                }
                catch (Exception ex)
                {
                    if (isUpdate)
                        transaction.Rollback();
                    throw ex;
                }

            }
            //return "";
        }
        public void ExecuteNow(string sql)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                DynamicParameters vals = new DynamicParameters();

                if (_parameters.Count > 0)
                {
                    foreach (var item in _parameters)
                    {
                        vals.Add("@" + item.Key, item.Value);
                    }
                }
                conn.Execute(sql, vals);
                conn.Close();

                this.ClearParam();
            }

        }

        public string VersionInfo()
        {
            var tempInfo = this.GetList<string>("SELECT * FROM V$VERSION");
            string ret = "";
            foreach (var item in tempInfo)
            {
                ret += item + ",";
            }
            if (!string.IsNullOrEmpty(ret))
                ret = ret.Substring(0, ret.Length - 1);
            return ret;
        }
        #region Private Model


        class InsertMod
        {
            public string TableName { get; set; }
            //Field name and Object Value
            public List<KeyValuePair<string, dynamic>> Field { get; set; }
        }

        class UpdateMod : InsertMod
        {
            public string ShortCriteria { get; set; }
            public List<CriteriaMod> Criteria { get; set; }
        }

        class CriteriaMod
        {
            public string Field { get; set; }
            public string Criteria { get; set; }
            public dynamic Data { get; set; }
        }
        #endregion
        //[AttributeUsage(AttributeTargets.Class)]
        //public class Key : Attribute
        //{
        //    public void Key(string key)
        //    {

        //    }
        //}
    }

    public class EnittyOneToManyMapper<TP, TC, TPk>
    {
        private readonly IDictionary<TPk, TP> _lookup = new Dictionary<TPk, TP>();

        public Action<TP, TC> AddChildAction { get; set; }

        public Func<TP, TPk> ParentKey { get; set; }


        public virtual TP Map(TP parent, TC child)
        {
            TP entity;
            var found = true;
            var primaryKey = ParentKey(parent);

            if (!_lookup.TryGetValue(primaryKey, out entity))
            {
                _lookup.Add(primaryKey, parent);
                entity = parent;
                found = false;
            }

            AddChildAction(entity, child);

            return !found ? entity : default(TP);

        }
    }

    public class QueryParameter
    {
        public string Query { get; set; }
        public List<KeyValuePair<string, dynamic>> Parameter { get; set; }
    }

}
