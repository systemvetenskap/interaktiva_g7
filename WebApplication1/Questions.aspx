<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Questions.aspx.cs" Inherits="WebApplication1.Questions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblQuestion" runat="server" Text="Fråga 1/25"></asp:Label><br />

        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Svar" /><label for="radio1"></label><br />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Svar" /><label for="radio1"></label><br />
        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="Svar" /><label for="radio1"></label><br />
        <asp:RadioButton ID="RadioButton4" runat="server" GroupName="Svar" /><label for="radio1"></label><br />
        <asp:RadioButton ID="RadioButton5" runat="server" GroupName="Svar" /><label for="radio1"></label><br />

    </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Nästa" />
    </form>
</body>
</html>
