using System.Collections.Generic;
using System.Linq;
using BookShop.DAL;
using BookShop.Model;

namespace BookShop.BLL 
{
	public partial class sysdiagramsBLL
	{
   		     
		/// <summary>
        /// 数据库操作对象
        /// </summary>
        private sysdiagramsDAL _dao = new sysdiagramsDAL();

        #region 向数据库中添加一条记录 +int Insert(sysdiagrams model)
        /// <summary>
        /// 向数据库中添加一条记录
        /// </summary>
        /// <param name="model">要添加的实体</param>
        /// <returns>插入数据的ID</returns>
        public int Insert(sysdiagrams model)
        {
            return _dao.Insert(model);
        }
        #endregion

        #region 删除一条记录 +int Delete(string name)
        public int Delete(string name)
        {
            return _dao.Delete(name);
        }
        #endregion

        #region 根据主键ID更新一条记录 +int Update(sysdiagrams model)
        /// <summary>
        /// 根据主键ID更新一条记录
        /// </summary>
        /// <param name="model">更新后的实体</param>
        /// <returns>执行结果受影响行数</returns>
        public int Update(sysdiagrams model)
        {
            return _dao.Update(model);
        }
        #endregion

        #region 分页查询一个集合 +IEnumerable<sysdiagrams> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        /// <summary>
        /// 分页查询一个集合
        /// </summary>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <param name="wheres">条件匿名类</param>
        /// <param name="orderField">排序字段</param>
        /// <param name="isDesc">是否降序排序</param>
        /// <returns>实体集合</returns>
        public IEnumerable<sysdiagrams> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        {
            return _dao.QueryList(index, size, wheres, orderField, isDesc);
        }
        #endregion

        #region 查询单个模型实体 +sysdiagrams QuerySingle(object wheres)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="wheres">条件匿名类</param>
        /// <returns>实体</returns>
        public sysdiagrams QuerySingle(object wheres)
        {
            return _dao.QuerySingle(wheres);
        }
        #endregion
        
        #region 查询单个模型实体 +sysdiagrams QuerySingle(string name)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="name">key</param>
        /// <returns>实体</returns>
        public sysdiagrams QuerySingle(string name)
        {
            return _dao.QuerySingle(name);
        }
        #endregion

        #region 查询条数 +int QueryCount(object wheres)
        /// <summary>
        /// 查询条数
        /// </summary>
        /// <param name="wheres">查询条件</param>
        /// <returns>实体</returns>
        public int QueryCount(object wheres)
        {
            return _dao.QueryCount(wheres);
        }
        #endregion
	}
}