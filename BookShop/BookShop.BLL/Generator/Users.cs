using System.Collections.Generic;
using System.Linq;
using BookShop.DAL;
using BookShop.Model;

namespace BookShop.BLL 
{
	public partial class UsersBLL
	{
   		     
		/// <summary>
        /// 数据库操作对象
        /// </summary>
        private UsersDAL _dao = new UsersDAL();

        #region 向数据库中添加一条记录 +int Insert(Users model)
        /// <summary>
        /// 向数据库中添加一条记录
        /// </summary>
        /// <param name="model">要添加的实体</param>
        /// <returns>插入数据的ID</returns>
        public int Insert(Users model)
        {
            return _dao.Insert(model);
        }
        #endregion

        #region 删除一条记录 +int Delete(int id)
        public int Delete(int id)
        {
            return _dao.Delete(id);
        }
        #endregion

        #region 根据主键ID更新一条记录 +int Update(Users model)
        /// <summary>
        /// 根据主键ID更新一条记录
        /// </summary>
        /// <param name="model">更新后的实体</param>
        /// <returns>执行结果受影响行数</returns>
        public int Update(Users model)
        {
            return _dao.Update(model);
        }
        #endregion

        #region 分页查询一个集合 +IEnumerable<Users> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        /// <summary>
        /// 分页查询一个集合
        /// </summary>
        /// <param name="index">页码</param>
        /// <param name="size">页大小</param>
        /// <param name="wheres">条件匿名类</param>
        /// <param name="orderField">排序字段</param>
        /// <param name="isDesc">是否降序排序</param>
        /// <returns>实体集合</returns>
        public IEnumerable<Users> QueryList(int index, int size, object wheres, string orderField, bool isDesc = true)
        {
            return _dao.QueryList(index, size, wheres, orderField, isDesc);
        }
        #endregion

        #region 查询单个模型实体 +Users QuerySingle(object wheres)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="wheres">条件匿名类</param>
        /// <returns>实体</returns>
        public Users QuerySingle(object wheres)
        {
            return _dao.QuerySingle(wheres);
        }
        #endregion
        
        #region 查询单个模型实体 +Users QuerySingle(int id)
        /// <summary>
        /// 查询单个模型实体
        /// </summary>
        /// <param name="id">key</param>
        /// <returns>实体</returns>
        public Users QuerySingle(int id)
        {
            return _dao.QuerySingle(id);
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
        public int Register(string name,string pwd)
        {
            if (QueryCount(new { LoginId=name})>0)
            {//用户名已存在
                return 1;//状态码
            }
            //对象初始化器
            Users u = new Users
            {
                LoginId = name,
                LoginPwd=pwd,
                Mail=string .Empty,
                Name=string.Empty,
                Phone=string.Empty,
                Address=string.Empty,
                UserStateId=1
            };           

            int id=_dao.Insert(u);//DAL层中Insert用的是ExcuteScalar(),返回的是首行首列，所以得到id
            if (id>0)
            {
                u.Id = id;
                return 0;//成功
            }
            else
            {//插入失败
                return 2;
            }
        }
        public LoginResult CheckLogin(string name, string pwd,out Users u)
        {           
            u = QuerySingle(new { LoginId = name });
            if (u!=null)
            {
                if (u.LoginPwd==pwd)
                {
                    return LoginResult.LoginSuccessful;
                }
                else
                {
                    //密码错误
                    return LoginResult.InvalidPassword;
                }
            }
            else
            {
                //用户名错误
                return LoginResult.InvalidUserName;
            }
        }


    }
}