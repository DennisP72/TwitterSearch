<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="TS.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 549px;
        }
    </style>
</head>
<body >
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <br />
        <br />
        <br />
        <br />
        <asp:Image ID="imgHeader" runat="server" ImageUrl="~/download.png" />
        <br />
        <asp:Label ID="lblHeader" runat="server" Font-Bold="True" Font-Names="Comic Sans MS" Font-Overline="False" Font-Size="XX-Large" ForeColor="#31A8E0" Text="Twitter Search"></asp:Label>
        <br />
    
        <asp:TextBox ID="txtSearch" runat="server" Width="299px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnSearch" runat="server" OnClick="Button1_Click" Text="Search" />
        <br />
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <br />
        <br />
    
        <br />
        <br />
        <asp:Panel ID="pnlTweets" runat="server" Height="200px" HorizontalAlign="Left" Width="600px">

        </asp:Panel>
    
    </div>

    </form>
</body>
</html>
