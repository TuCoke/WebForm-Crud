using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using Model;

namespace Music.Web
{
    public partial class index : System.Web.UI.Page
    {
        MusicBLL ubll = new MusicBLL();

        public void DataBind()
        {
            DataTable dt = ubll.GetAllUser();
            //绑定
            GridView1.DataKeyNames = new string[] { "Id" };
            //把获取的数据源绑定到控件上面
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                //页面加载的事件
                //渲染数据表格

                DataBind();
        }

        

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 删除id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var selectIndex = e.RowIndex;
            var id = (GridView1.DataKeys[selectIndex].Value as int?).Value;
            MusicBLL ubll = new MusicBLL();
            bool rs = ubll.DeleteByID(id);
            if (rs == true)
            {
                Response.Redirect("index.aspx");
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            var selectIndex = e.RowIndex;
            var id = (GridView1.DataKeys[selectIndex].Value as int?).Value;
            var title = (GridView1.Rows[selectIndex].Cells[1].Controls[0] as TextBox).Text.ToString();

            var duration = Convert.ToInt32((GridView1.Rows[selectIndex].Cells[2].Controls[0] as TextBox).Text.ToString());
            //Singer=GridView1.Columns["标题"]
            var singer = (GridView1.Rows[selectIndex].Cells[3].Controls[0] as TextBox).Text.ToString();
            var model = new MusicInfo
            {
                Id=id,
                Title=title,
                Duration=duration,
               Singer=singer
            };
           bool rs= ubll.MusicEd(model);
            if (rs==true)
            {
                Response.Redirect("index.aspx");
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            DataBind();
        }
    }
}