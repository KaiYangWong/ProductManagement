using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using prjWebForm.Models;

namespace prjWebForm
{
    public partial class Edit : System.Web.UI.Page
    {
        dbProductEntities db = new dbProductEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string fId = Request.QueryString["fId"].ToString();

                var product = db.tProduct
                                .Where(m => m.fId == fId)
                                .FirstOrDefault();

                txtId.Text = product.fId;
                txtName.Text = product.fName;
                txtPrice.Text = product.fPrice.ToString();

                if (product.fImg == "")
                {
                    lblShowImg.Text = "無圖示";
                }
                else
                {
                    lblShowImg.Text = "<img src='images/" + product.fImg + "' width='200>";
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string fId, fileName;

            fId = txtId.Text;

            var product = db.tProduct
                            .Where(m => m.fId == fId)
                            .FirstOrDefault();

            fileName = product.fImg;

            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("Images") + "/" + FileUpload1.FileName);
                fileName = FileUpload1.FileName;
            }

            product.fName = txtName.Text;
            product.fPrice = decimal.Parse(txtPrice.Text);
            product.fImg = fileName;
            db.SaveChanges();
            Response.Redirect("Index.aspx");
        }
    }
}