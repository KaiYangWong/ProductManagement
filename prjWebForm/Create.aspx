﻿<%@ Page Title="新增產品" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="prjWebForm.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>產品新增</h2>
   <div class="form-horizontal">
       <hr />
       <div class="form-group">
           <label for="id" class="control-label col-md-2">編號</label>
           <div class="col-md-10">
               <asp:TextBox ID="txtId" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
       </div>

       <div class="form-group">
           <label for="name" class="control-label col-md-2">品名</label>
           <div class="col-md-10">
               <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
       </div>

       <div class="form-group">
           <label for="price" class="control-label col-md-2">單價</label>
           <div class="col-md-10">
               <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
       </div>

       <div class="form-group">
           <label for="img" class="control-label col-md-2">圖</label>
           <asp:FileUpload ID="FileUpload1" runat="server" />
       </div>

       <div class="form-group">
           <div class="col-md-offset-2 col-md-10">
               <asp:Button ID="btnCreate" CssClass="btn btn-default" runat="server" Text="新增" OnClick="btnCreate_Click" />
               <asp:Label ID="lblError" runat="server"></asp:Label>
           </div>
       </div>
   </div>

   <div>
       <a href="Index.aspx">返回商品列表</a>
   </div>
</asp:Content>
