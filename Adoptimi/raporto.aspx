<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="raporto.aspx.cs" Inherits="Adoptimi.raporto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url(uploads/cat1.jpg)">
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Përshkrim i raportimit për kafshën e humbur" Font-Names="Andalus" Font-Size="Large" ForeColor="#A45200"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="131px" Width="307px" TextMode="MultiLine" BackColor="#E9E9E9" BorderColor="#FF6600" BorderStyle="Double" Font-Italic="True" ></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Emri i fotos" Font-Names="Andalus" Font-Size="Large" ForeColor="#A45200"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Height="23px" Width="144px" BackColor="White" BorderColor="#FF6600" BorderStyle="Double"></asp:TextBox>
        &nbsp;<br />
        <asp:Label ID="Label4" runat="server" Font-Names="Andalus" Font-Size="Large" ForeColor="#A45200" Text="Ngarko foton"></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" BorderColor="#FF6600" BorderStyle="Double" Height="31px" Width="210px" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Posto" BackColor="#0066FF" Height="26px" Width="84px" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Ne rast se kafsha juaj eshte gjetur ju lutem plotesoni numrin e raportit" Font-Bold="True" Font-Italic="True"></asp:Label>
        <br />
        <asp:TextBox ID="nraporti" runat="server" BorderColor="#FF6600" BorderStyle="Double"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Ndrysho" BackColor="Blue" Height="25px" Width="98px" />
        <br />
    </form>
</body>
</html>
