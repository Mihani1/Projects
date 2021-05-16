<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="identifikohu2.aspx.cs" Inherits="Adoptimi.identifikohu2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Identifikohu</title>
    <style type="text/css">
        .div1 {
            position: absolute;
            height: 200px;
            width: 400px;
            margin: -100px 0 0 -200px;
            top: 30%;
            left: 50%;
            border: 1px solid #ccc;
            background-color: #f3f3f3;
            background-image: url(http://www.kittenswhiskers.com/wp-content/uploads/sites/48/2014/01/white-cat-blue-eyes-640x360.jpg);
            background-size: 100% 100%;
            opacity: 0,6;
        }

        .validator {
            color: white;
            font-weight: bold;
        }

        .button {
            font-size: 11px;
            font-weight: bold;
            font-family: Arial;
            color: #ffffff;
            min-width: 54px;
            height: 24px;
            white-space: nowrap;
            cursor: pointer;
            outline: 0 none;
            padding: 0 10px 2px;
            text-align: center;
            border-radius: 2px 2px 2px 2px;
            border: 1px solid #4980C1;
            filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#5384BE', endColorstr='#4386D7'); /* for IE */
            -ms-filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#5384BE', endColorstr='#4386D7'); /* for IE 8 and above */
            background: -webkit-gradient(linear, left top, left bottom, from(#5384BE), to(#4386D7)); /* for webkit browsers */
            background: -moz-linear-gradient(top, #5384BE, #4386D7); /* for firefox 3.6+ */
            background: -o-linear-gradient(top, #5384BE, #4386D7); /* for Opera */
        }

            .button:hover {
                cursor: pointer;
                filter: progid:DXImageTransform.Microsoft.gradient(startColorstr=' #85B6F0', endColorstr='#579AEB'); /* for IE */
                -ms-filter: progid:DXImageTransform.Microsoft.gradient(startColorstr=' #85B6F0', endColorstr='#579AEB'); /* for IE 8 and above */
                background: -webkit-gradient(linear, left top, left bottom, from(#85B6F0), to(#579AEB)); /* for webkit browsers */
                background: -moz-linear-gradient(top, #85B6F0, #579AEB); /* for firefox 3.6+ */
                background: -o-linear-gradient(top, #85B6F0, #579AEB); /* for Opera */
            }
    </style>
</head>
<body  style="background-image:url(uploads/v.png )">
    <form id="form1" runat="server">
        <div style="font-weight: 700; text-align: center; font-size: 30px">
            Identifikohu<br />
        </div>
        <div class="div1">
            <table>
                <tr>
                    <td>Username:</td>
                    <td>
                        <asp:TextBox ID="Username" runat="server" placeholder="Username"/>
                        <asp:RequiredFieldValidator class="validator" ID="rfvUser" ErrorMessage="<br/>Vendosni Username." ControlToValidate="Username" runat="server" />
                        <asp:Label ID="ErrorUsername" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Fjalëkalimi:</td>
                    <td>
                        <asp:TextBox ID="Fjalekalimi" runat="server" TextMode="Password" placeholder="Fjalëkalimi"/>
                        <asp:RequiredFieldValidator class="validator" ID="rfvPWD" runat="server" ControlToValidate="Fjalekalimi" ErrorMessage="<br/>Vendosni fjalekalimin." />
                        <asp:Label ID="ErrorFjalekalimi" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button class="button" ID="btnSubmit"  runat="server"  Text="Identifikohu" OnClick="btnSubmit_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
               
                        <strong>
                            <asp:Label ID="label1" runat="server"></asp:Label></strong>

                    </td>
                    <td>
                        <asp:Button ID="button1" Class="button" runat="server" Text="Log out" OnClick="button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td>Nëse nuk keni një llogari, atëherë:</td>
                    <td><asp:Button class="button" ID="Button2" onClientClick="location.href='Rregjistrim.aspx'" runat="server" Text="Krijo llogari" OnClick="Button2_Click" /></td>
                </tr>
                
            </table>
        </div>

    </form>
</body>
</html>
