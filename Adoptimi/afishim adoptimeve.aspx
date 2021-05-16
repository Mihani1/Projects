<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="afishim adoptimeve.aspx.cs" Inherits="Adoptimi.afishim_adoptimeve" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image:url( uploads/q.png)">
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" CellPadding="3" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellSpacing="2" >
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
            <Columns>
                <asp:TemplateField HeaderText="Nr_adoptimit">
                    <ItemTemplate>
                        <asp:label ID="nra" runat="server" Text='<%#Eval("nr_adoptimi") %>'></asp:label>
                    </ItemTemplate>
               </asp:TemplateField>
                <asp:TemplateField HeaderText="Emri i kafshes ">
                    <ItemTemplate>
                        <asp:label ID="emk" runat="server" Text='<%#Eval("em_kafshes") %>'></asp:label>
                    </ItemTemplate>
               </asp:TemplateField>
                <asp:TemplateField HeaderText="Mosha(muaj)">
                    <ItemTemplate>
                        <asp:label ID="mosha" runat="server" Text='<%#Eval("mosha") %>'></asp:label>
                    </ItemTemplate>
               </asp:TemplateField>
                <asp:TemplateField HeaderText="Email">
                    <ItemTemplate>
                        <asp:label ID="email" runat="server" Text='<%#Eval("email") %>'></asp:label>
                    </ItemTemplate>
               </asp:TemplateField>
                 <asp:TemplateField HeaderText="Nr.Kontaktit">
                    <ItemTemplate>
                        <asp:label ID="nrk" runat="server" Text='<%#Eval("nr_kontakti") %>'></asp:label>
                    </ItemTemplate>
               </asp:TemplateField>
                 <asp:TemplateField HeaderText="Sasia">
                    <ItemTemplate>
                        <asp:label ID="sasia" runat="server" Text='<%#Eval("sasia") %>'></asp:label>
                    </ItemTemplate>
               </asp:TemplateField>
                <asp:TemplateField HeaderText="Adoptuar(po/jo)">
                    <ItemTemplate>
                        <asp:label ID="adoptuar" runat="server" Text='<%#Eval("adoptuar") %>'></asp:label>
                    </ItemTemplate>
               </asp:TemplateField>
                <asp:TemplateField HeaderText="Foto">
                    <ItemTemplate>
                        <asp:Image ID="img" runat="server" ImageUrl='<%#Eval("imazh") %>' Height="100" Width="100"></asp:Image>
                    </ItemTemplate>
               </asp:TemplateField>
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
