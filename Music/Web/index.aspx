<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Music.Web.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

</head>
<body aria-live="polite">
    <form id="form1" runat="server">
        <div>
            <div class="box">
        <button type="button" class="btn btn-default" id="Increase"><a href="Web/Add.aspx">增加</a></button>
            </div>
         <asp:GridView ID="GridView1" runat="server" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating"
             OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" AutoGenerateColumns="False" >
             <Columns>
                 <asp:BoundField DataField="Id" HeaderText="编号" />
                 <asp:BoundField DataField="Title" HeaderText="标题" />
                 <asp:BoundField DataField="Duration" HeaderText="时长？" />
                 <asp:BoundField DataField="Singer" HeaderText="歌手？" />
                 <asp:ButtonField  CommandName="Delete"  HeaderText="删除" Text="删除" />
                 <asp:ButtonField CommandName="Edit" HeaderText="编辑" Text="编辑" />
                 <asp:CommandField ShowEditButton="true" />
             </Columns>
          </asp:GridView>
          
        </div>
    </form>

</body>
</html>
