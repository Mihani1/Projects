<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adopto.aspx.cs" Inherits="Adoptimi.adopto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url( uploads/dogs.jpg)">
    <form id="form1" runat="server">
    <div>
    
                <asp:Label ID="Label1" runat="server" Text="Emri Kafshes" Font-Names="Andalus" Font-Size="Large" ForeColor="#753A00"></asp:Label>&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
                <asp:TextBox ID="TextBox1" runat="server"  Height="22px" Width="151px" BackColor="White" BorderColor="#FF6600" BorderStyle="Double"></asp:TextBox>
                <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Mosha(muaj)" Font-Names="Andalus" Font-Size="Large" ForeColor="#753A00"></asp:Label>&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Height="22px" Width="151px" BorderColor="#FF6600" BorderStyle="Double"></asp:TextBox>
                <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Email" Font-Names="Andalus" Font-Size="Large" ForeColor="#753A00"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Height="22px" style="margin-left: 0px" Width="151px" BorderColor="#FF6600" BorderStyle="Double"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Nr. Kontakti" Font-Names="Andalus" Font-Size="Large" ForeColor="#753A00"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox4" runat="server" Height="22px" Width="151px" BorderColor="#FF6600" BorderStyle="Double"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" Text="Sasia( per adoptim)" Font-Names="Andalus" Font-Size="Large" ForeColor="#753A00"></asp:Label>
        

                &nbsp;<asp:TextBox ID="TextBox5" runat="server" Height="22px" Width="151px" BorderColor="#FF6600" BorderStyle="Double"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                Emri fotos &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox6" runat="server" BorderColor="#FF6600" BorderStyle="Double" Height="22px" Width="151px"></asp:TextBox>
                <br />
                <br />
                Upload a image
                <asp:FileUpload ID="FileUpload1" runat="server" BorderColor="#FF6600" BorderStyle="Double" />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Height="32px" OnClick="Button2_Click" Text="Posto" Width="100px" BackColor="#0066FF" BorderStyle="None" Font-Bold="True" />
                <br />
                <asp:Label ID="L1" runat="server" Text="Label" Font-Bold="True" Font-Size="Large" ForeColor="#FF3300"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" Text="Ne rast  se kafsha  juaj eshte adoptuar  , plotesoni numrin e adoptimit per te ndryshuar statusin e tij " Font-Bold="True" Font-Italic="True"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label10" runat="server" Text="Nr adoptimit" Font-Names="Andalus" ForeColor="#753A00"></asp:Label>
                <br />
                <asp:TextBox ID="adoptuar" runat="server" BorderColor="#FF6600" BorderStyle="Double"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Ndrysho" BackColor="#0066FF" Font-Bold="True" Height="34px" Width="84px" />
                <br />
                <br />
                <asp:Label ID="Label7" runat="server" Text="Per te ndryshuar sasine ju lutem plotesoni me  poshte nr e sasise dhe nr e  adoptimit" Font-Bold="True" Font-Italic="True"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label8" runat="server" Text="Sasia e re" Font-Names="Andalus" ForeColor="#753A00"></asp:Label>
                <asp:TextBox ID="TextBox7" runat="server" BorderColor="#FF6600" BorderStyle="Double"></asp:TextBox>
&nbsp;&nbsp;
                <asp:Label ID="Label9" runat="server" Text="Nr adoptimit" Font-Names="Andalus" ForeColor="#753A00"></asp:Label>
&nbsp;&nbsp;
                <asp:TextBox ID="TextBox8" runat="server" BorderColor="#FF6600" BorderStyle="Double"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Ndrysho sasine" BackColor="#0066FF" Font-Bold="True" Font-Italic="False" Height="32px" Width="161px" />
                <br />
        

    </div>
    </form>
</body>
</html>
