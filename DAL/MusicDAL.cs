using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;

namespace DAL
{
    public class MusicDAL
    {
        /// <summary>
        /// 展示所有
        /// </summary>
        /// <returns></returns>
        public DataTable SelectUser()
        {
            string constr = @"server=(localdb)\MSSQLLocalDB;database=CloudMusicDB;uid=sa;pwd=123456";//sql server身份验证
            SqlConnection conn = new SqlConnection(constr);
            //2，实例化适配器对象
            string sql = "select * from HotSongs";
            //
            SqlDataAdapter sda = new SqlDataAdapter(sql, constr);

            DataSet ds = new DataSet();
            DataTable table = new DataTable();
            sda.Fill(ds);
           // string json = JsonConvert.SerializeObject(ds.Tables[0]);
           
            return ds.Tables[0];

        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteByID(int id)
        {
            string constr = @"server=(localdb)\MSSQLLocalDB;database=CloudMusicDB;uid=sa;pwd=123456";//sql server身份验证
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            //2，实例化适配器对象
            String sql = String.Format("delete from HotSongs where Id = {0}", id);
            //
            SqlCommand cmd = new SqlCommand(sql, conn);
            int rs = cmd.ExecuteNonQuery();
            return true;
        }
        /// <summary>
        /// 增加歌手
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        //新增一个用户
        public bool AddMusic(MusicInfo music)
        {
            //拼接sql语句
            string constr = @"server=(localdb)\MSSQLLocalDB;database=CloudMusicDB;uid=sa;pwd=123456";//sql server身份验证
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            String sql = String.Format(@"insert into HotSongs (Title,Duration,Singer) 
                            values('{0}','{1}','{2}')", music.Title, music.Duration, music.Singer);
            SqlCommand cmd = new SqlCommand(sql, conn);
            int rs = cmd.ExecuteNonQuery();
            return true;
            //返回值

        }
        /// <summary>
        /// 修改歌手
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool MusicEd(MusicInfo music)
        {
            string constr = @"server=(localdb)\MSSQLLocalDB;database=CloudMusicDB;uid=sa;pwd=123456";//sql server身份验证
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            //拼接sql语句
            String sql = String.Format(@"update [HotSongs] set Title='{0}',Duration='{1}',Singer='{2}'
                            where id ={3}",  music.Title, music.Duration, music.Singer, music.Id);
            SqlCommand cmd = new SqlCommand(sql, conn);
            int rs = cmd.ExecuteNonQuery();

            return true;
        }
        /// <summary>
        /// 修改页面传递id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
       public DataTable SelecrMusicId(int id)
        {
            string constr = @"server=(localdb)\MSSQLLocalDB;database=CloudMusicDB;uid=sa;pwd=123456";//sql server身份验证
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            //执行数据库查询语句 需要DBHelper
            String sql =
                String.Format("select * from HotSongs where UserId={0}", id);
            //拼接sql语句
            SqlDataAdapter sda = new SqlDataAdapter(sql, constr);
            DataSet ds = new DataSet();
            DataTable table = new DataTable();
            sda.Fill(ds);
            return ds.Tables[0];
        }

    }
}
