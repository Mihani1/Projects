<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="afishimi raportimit.aspx.cs" Inherits="Adoptimi.afishimi_raportimit" %>

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

                <asp:TemplateField HeaderText="Nr.Raportimit">
                    <ItemTemplate>
                        <asp:label ID="gjetur" runat="server" Text='<%#Eval("nr_raporti") %>'></asp:label>
                    </ItemTemplate>
                          </asp:TemplateField>
                  <asp:TemplateField HeaderText="Pershkim" ItemStyle-Width="500">
                    <ItemTemplate>
                       
                        <asp:label ID="pershkrim" runat="server" Text='<%#Eval("pershkrimi").ToString().Replace("\n", "<br />") %>'></asp:label>
                    </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="Gjetur(po/jo)">
                    <ItemTemplate>
                        <asp:label ID="gjetur" runat="server" Text='<%#Eval("i_gjetur") %>'></asp:label>
                    </ItemTemplate>
                          </asp:TemplateField>
                      <asp:TemplateField HeaderText="Foto">
                    <ItemTemplate>
                        <asp:Image ID="img1" runat="server" ImageUrl='<%#Eval("imazh") %>' Height="100" Width="100"></asp:Image>
                    </ItemTemplate>
               </asp:TemplateField>
                </Columns>
             </asp:GridView>
    
    </div>
    </form>
</body>
</html>
