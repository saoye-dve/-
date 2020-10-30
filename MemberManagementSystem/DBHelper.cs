using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace MemberManagementSystem
{
    /// <summary>
    /// 维护数据库连接字符串和Connection对象；
    /// </summary>
    class DBHelper
    {
        private string str = "Data Source=.;Initial Catalog=MemberManagementDB;Integrated Security=True";

        /// <summary>
        /// 数据库连接connection对象
        /// </summary>
        private SqlConnection connection;
        public SqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new SqlConnection(str);
                }
                return connection;
            }
        }


        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Close();
                Connection.Open();
            }
            else if (Connection.State == ConnectionState.Broken)
            {
                Connection.Close();
                Connection.Open();
            }
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open || Connection.State == ConnectionState.Broken)
            {
                Connection.Close();
            }
        }

    }
}
