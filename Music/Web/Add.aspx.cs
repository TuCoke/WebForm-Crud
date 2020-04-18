using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace Music.Web
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_AddUser_Click(object sender, EventArgs e)
        {
            //添加歌曲
            MusicInfo music = new MusicInfo();
            music.Title = this.Title.Text;
            music.Duration =Convert.ToInt32(this.Duration.Text);
            music.Singer = this.Singer.Text;
            MusicBLL mus = new MusicBLL();
            bool result = mus.AddMusic(music);
            if (result==true)
            {
                Response.Write("<script language='javascript'>alert('增加成功')</script>");
            }
        }
    }
}