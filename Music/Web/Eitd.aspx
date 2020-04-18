<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Eitd.aspx.cs" Inherits="Music.Web.Eitd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <h1 class="text-center">添加歌曲</h1>
             <div>
                <asp:Label ID="Label1" runat="server" Text="标题：" CssClass="control-label"></asp:Label>
                <asp:TextBox ID="Title" runat="server" CssClass="form-control"></asp:TextBox>
                 </div>
          <div>
                <asp:Label ID="Label2" runat="server"  Text="时长：" CssClass="control-label"></asp:Label>
                <asp:TextBox ID="Duration" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
                    <asp:Label ID="Label4" runat="server"  Text="歌手：" CssClass="control-label"></asp:Label>
                <asp:TextBox ID="Singer" runat="server" CssClass="form-control"></asp:TextBox>
               <div>
                <asp:Button ID="btn_AddUser" runat="server" 
                    CssClass="btn btn-block btn-danger" Text="确认添加" OnClick="btn_AddUser_Click" />
            </div>
    </form>
</body>
</html>
