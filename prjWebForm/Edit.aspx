<%@ Page Title="產品編輯" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="prjWebForm.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <h2>產品編輯</h2>
    <div class="form-horizontal">
        <hr />
        <asp:TextBox ID="txtId" runat="server" Class="form-control" Visible="false"></asp:TextBox>

        <div class="form-group">
            <label for="name" class="control-label col-md-2">品名</label>
            <div class="col-md-10">
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <label for="price" class="control-label col-md-2">單價</label>
            <div class="col-md-10">
                <asp:TextBox ID="txtPrice" runat="server" Class="form-control" TextMode="Number"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <label for="img" class="control-label col-md-2">圖示</label>
            <div class="col-md-10">
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </div>
            <div class="col-md-10">
                <asp:Label ID="lblShowImg" runat="server" Text="Label"></asp:Label>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="btnSave" runat="server" Text="儲存" class="btn btn-default" OnClick="btnSave_Click"/>
            </div>
        </div>
    </div>
</asp:Content>
