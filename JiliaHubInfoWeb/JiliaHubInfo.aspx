<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JiliaHubInfo.aspx.cs" Inherits="JiliaHubInfoWeb.JiliaHubInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>

            <asp:GridView ID="GridViewInfo" runat="server" Style="margin-top: 17px" Visible="True">
            </asp:GridView>

        </div>
    </form>
</body>
</html>
