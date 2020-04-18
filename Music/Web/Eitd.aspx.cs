using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using System.Data;

namespace Music.Web
{
    public partial class Eitd : System.Web.UI.Page
    {
        MusicBLL ubll = new MusicBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int musicid = Convert.ToInt32(Request.QueryString["Id"]);
            MusicInfo us = ubll.GetEtable(musicid);
            this.Title.Text = us.Title;
            this.Duration.Text =Convert.ToString(us.Duration);
            this.Singer.Text = us.Singer;


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}