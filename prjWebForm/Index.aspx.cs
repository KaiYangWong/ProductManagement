using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using prjWebForm.Models;

namespace prjWebForm
{
    public partial class Index : System.Web.UI.Page
    {
        dbProductEntities db = new dbProductEntities();
        
        //網頁載入時執行
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                loadData();
            }
        }

        void loadData()
        {
            GridView1.DataSource = db.tProduct.ToList();
            GridView1.DataBind();
        }

        //當控制項的CommandName按鈕被按時會觸發RowCommand事件
        protected void GridView1_RowCommand(object sender,GridViewCommandEventArgs e)
        {
            string fId = e.CommandArgument.ToString();

            if(e.CommandName == "編輯")
            {
                Response.Redirect("Edit.aspx?fId=" + fId);
            }
            else if(e.CommandName == "刪除")
            {
                //取得目前的產品
                var product = db.tProduct
                                .Where(m => m.fId == fId)
                                .FirstOrDefault();
                string fileName = product.fImg;

                if(fileName != "")
                {
                    //刪除指定圖檔
                    System.IO.File.Delete(Server.MapPath("~/Images") + "/" + fileName);
                }

                db.tProduct.Remove(product);
                db.SaveChanges();
                loadData();
            }
        }
    }
}