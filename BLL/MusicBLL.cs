using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data;


namespace BLL
{
    public class MusicBLL
    {
        MusicDAL udal = new MusicDAL();
        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllUser()
        {
            return udal.SelectUser();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteByID(int id)
        {
            return udal.DeleteByID(id);
        }
        /// <summary>
        /// 增加歌手
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        //新增一个用户
        public bool AddMusic(MusicInfo music)
        {
            //创建 new数据访问层的对象
            //调用新增用户的方法
            bool result = udal.AddMusic(music);
            //返回值
            return result;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="music"></param>
        /// <returns></returns>
        public MusicInfo GetEtable(int id)
        {
            DataTable dt = udal.SelecrMusicId(id);
            MusicInfo music = new MusicInfo();
            music.Id= Convert.ToInt32(dt.Rows[0][0].ToString());
            music.Title = dt.Rows[0][1].ToString();
            music.Duration = Convert.ToInt32(dt.Rows[0][2].ToString());
            music.Singer = dt.Rows[0][3].ToString();
            return music;
        }
        public bool MusicEd(MusicInfo model)
        {
            bool result = udal.MusicEd(model);
            return result;
        }
    }
}
