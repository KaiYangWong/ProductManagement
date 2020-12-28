﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using prjWebForm.Models;

namespace prjWebForm
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //圖檔儲存
                string fileName = "";

                if (FileUpload1.HasFile)
                {
                    FileUpload1.SaveAs(Server.MapPath("images") + "/" + FileUpload1.FileName);
                    fileName = FileUpload1.FileName;
                }

                //新增記錄
                dbProductEntities db = new dbProductEntities();
                tProduct product = new tProduct();
                product.fId = txtId.Text;
                product.fName = txtName.Text;
                product.fPrice = decimal.Parse(txtPrice.Text);
                product.fImg = fileName;
                db.tProduct.Add(product);
                db.SaveChanges();

                Response.Redirect("Index.aspx");
            }
            catch(Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}