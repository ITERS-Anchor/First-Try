using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using BookShop.Model;
using BookShop.Utility;

namespace BookShop.DAL
{
	public partial class SysFunDAL
	{
        #region 向数据库中添加一条记录 +int Insert(SysFun model)
        /// <summary>
        /// 向数据库中添加一条记录
        /// </summary>
        /// <param name="model">要添加的实体</param>
        /// <returns>插入数据的ID</returns>
        public int Insert(SysFun model)
        {
            #region SQL语句
            const string sql = @"
INSERT INTO [dbo].[SysFun] (
	[NodeId]
	,[DisplayName]
	,[NodeURL]
	,[DisplayOrder]
	,[ParentNodeId]
)
VALUES (
	@NodeId
	,@DisplayName
	,@NodeURL
	,@DisplayOrder
	,@ParentNodeId
);select @@IDENTITY";
            #endregion
            var res = SqlHelper.ExecuteScalar(sql,
					new SqlParameter("@NodeId", model.NodeId),					
					new SqlParameter("@DisplayName", model.DisplayName),					
					new SqlParameter("@NodeURL", model.NodeURL),					
					new SqlParameter("@DisplayOrder", model.DisplayOrder),					
					new SqlParameter("@ParentNodeId", model.ParentNodeId)					
                );
            return res == null ? 0 : Convert.ToInt32(res);
        }
        #endregion

        #region 删除一条记录 +int Delete(int nodeid)
        public int Delete(int nodeid)
        {
            const string sql = "DELETE FROM [dbo].[SysFun] WHERE [NodeId] = @NodeId";
            return SqlHelper.ExecuteNonQuery(sql, new SqlParameter("@NodeId", nodeid));
        }
        #endregion

        #region 根据主键ID更新一条记录 +int Update(SysFun model)
        /// <summary>
        /// 根据主键ID更新一条记录
        /// </summary>
        /// <param name="model">更新后的实体</param>
        /// <returns>执行结果受影响行数</returns>
        public int Update(SysFun model)
        {
            #region SQL语句
            const string sql = @"
UPDATE [dbo].[SysFun]
SET 
	[NodeId] = @NodeId
	,[DisplayName] = @DisplayName
	,[NodeURL] = @NodeURL
	,[DisplayOrder] = @DisplayOrder
	,[ParentNodeId] = @ParentNodeId
WHERE [NodeId] = @NodeId";
            #endregion
            return SqlHelper.ExecuteNonQuery(sql,
					new SqlParameter("@NodeId", model.NodeId),					
					new SqlParameter("@DisplayName", model.DisplayName),					
					new SqlParameter("@NodeURL", model.NodeURL),					
					new SqlParameter("@DisplayOrder", model.DisplayOrder),					
					new SqlParameter("@ParentNodeId", model.ParentNodeId)					
                );
        }
        #endregion

        #region 分页查询一个集合 +IEnumerable<SysFun> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        /// <summary>
        /// 分页查询一个集合
        /// </summary>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <param name="wheres">条件匿名类</param>
        /// <param name="orderField">排序字段</param>
        /// <param name="isDesc">是否降序排序</param>
        /// <returns>实体集合</returns>
        public IEnumerable<SysFun> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        {
            var parameters = new List<SqlParameter>();
            var whereBuilder = new System.Text.StringBuilder();
            if (wheres != null)
            {
                var props = wheres.GetType().GetProperties();
                foreach (var prop in props)
                {
                    if (prop.Name.Equals("__o", StringComparison.InvariantCultureIgnoreCase))
                    {
                        // 操作符
                        whereBuilder.AppendFormat(" {0} ", prop.GetValue(wheres, null).ToString());
                    }
                    else
                    {
                        var val = prop.GetValue(wheres, null).ToString();
                        whereBuilder.AppendFormat(" [{0}] = @{0} ", prop.Name);
                        parameters.Add(new SqlParameter("@" + prop.Name, val));
                    }
                }
            }
            var sql = SqlHelper.GenerateQuerySql("SysFun", new[] { "NodeId", "DisplayName", "NodeURL", "DisplayOrder", "ParentNodeId" }, index, size, whereBuilder.ToString(), orderField, isDesc);
            using (var reader = SqlHelper.ExecuteReader(sql, parameters.ToArray()))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        yield return SqlHelper.MapEntity<SysFun>(reader);
                    }
                }
            }
        }
        #endregion

        #region 查询单个模型实体 +SysFun QuerySingle(object wheres)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="wheres">条件匿名类</param>
        /// <returns>实体</returns>
        public SysFun QuerySingle(object wheres)
        {
            var list = QueryList(1, 1, wheres, null);
            return list != null && list.Any() ? list.FirstOrDefault() : null;
        }
        #endregion

        #region 查询单个模型实体 +SysFun QuerySingle(int nodeid)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="nodeid">key</param>
        /// <returns>实体</returns>
        public SysFun QuerySingle(int nodeid)
        {
            const string sql = "SELECT TOP 1 [NodeId], [DisplayName], [NodeURL], [DisplayOrder], [ParentNodeId] FROM [dbo].[SysFun] WHERE [NodeId] = @NodeId";
            using (var reader = SqlHelper.ExecuteReader(sql, new SqlParameter("@NodeId", nodeid)))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    return SqlHelper.MapEntity<SysFun>(reader);
                }
                else
                {
                    return null;
                }
            }
        }
        #endregion

        #region 查询条数 +int QueryCount(object wheres)
        /// <summary>
        /// 查询条数
        /// </summary>
        /// <param name="wheres">查询条件</param>
        /// <returns>条数</returns>
        public int QueryCount(object wheres)
        {
            var parameters = new List<SqlParameter>();
            var whereBuilder = new System.Text.StringBuilder();
            if (wheres != null)
            {
                var props = wheres.GetType().GetProperties();
                foreach (var prop in props)
                {
                    if (prop.Name.Equals("__o", StringComparison.InvariantCultureIgnoreCase))
                    {
                        // 操作符
                        whereBuilder.AppendFormat(" {0} ", prop.GetValue(wheres, null).ToString());
                    }
                    else
                    {
                        var val = prop.GetValue(wheres, null).ToString();
                        whereBuilder.AppendFormat(" [{0}] = @{0} ", prop.Name);
                        parameters.Add(new SqlParameter("@" + prop.Name, val));
                    }
                }
            }
            var sql = SqlHelper.GenerateQuerySql("SysFun", new[] { "COUNT(1)" }, whereBuilder.ToString(), string.Empty);
            var res = SqlHelper.ExecuteScalar(sql, parameters.ToArray());
            return res == null ? 0 : Convert.ToInt32(res);
        }
        #endregion
	}
}