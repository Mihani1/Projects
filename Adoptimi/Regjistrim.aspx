<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Regjistrim.aspx.cs" Inherits="Adoptimi.Regjistrim" %>

<!DOCTYPE html>
<html lang="en">
<head>

    <style type="text/css">
        .div1 {
        position: absolute;
        height: 493px;
        width: 400px;
        margin: -100px 0 0 -200px;
        top: 161%;
        left: 51%;
        border: 1px solid #ccc;
        background-color: #f3f3f3;
        background-size: 100% 100%;
        opacity: 0,6;
    }

    h1 {
        font-weight: 700;
        text-align: center;
        font-size: 30px;
    }

    .button {
        font-size: 11px;
        font-weight: bold;
        font-family: Arial;
        color: #FFF;
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
    <title>Miqte me 4 Putra</title>
    <meta charset="utf-8">
    <link rel="icon" href="images1/favicon.ico">
    <link rel="shortcut icon" href="images1/favicon.ico">
    <link rel="stylesheet" href="css1/style.css">
    <link rel="stylesheet" href="css1/slider.css">
    <script src="js/jquery.js"></script>
    <script src="js/jquery-migrate-1.1.1.js"></script>
    <script src="js/superfish.js"></script>
    <script src="js/jquery.carouFredSel-6.1.0-packed.js"></script>
    <script src="js/jquery.equalheights.js"></script>
    <script src="js/jquery.easing.1.3.js"></script>
    <script src="js/tms-0.4.1.js"></script>
    <script src="js/jquery.ui.totop.js"></script>
    <script>
$(window).load(function () {
    $('.slider')._TMS({
        show: 0,
        pauseOnHover: false,
        prevBu: '.prev',
        nextBu: '.next',
        playBu: false,
        duration: 800,
        preset: 'fade',
        pagination: true, //'.pagination',true,'<ul></ul>'
        pagNums: false,
        slideshow: 8000,
        numStatus: false,
        banners: true,
        waitBannerAnimation: false,
        progressBar: false
    })
});
$(window).load(function () {
    $('.carousel1').carouFredSel({
        auto: false,
        prev: '.prev',
        next: '.next',
        width: 960,
        items: {
            visible: {
                min: 3,
                max: 3
            },
            height: 'auto',
            width: 300,
        },
        responsive: true,
        scroll: 1,
        mousewheel: false,
        swipe: {
            onMouse: true,
            onTouch: true
        }
    });
});
jQuery(document).ready(function () {
    $().UItoTop({
        easingType: 'easeOutQuart'
    });
});
    </script>
    <!--[if lt IE 9]>
    <script src="js/html5shiv.js"></script>
    <link rel="stylesheet" media="screen" href="css/ie.css">
    <![endif]-->
</head>
    <body class="page1">
    <header>
        <div class="container_12">
            <div class="grid_12">
                <h1><a href="index1.html"><img src="images1/logo.png" alt=""></a> </h1>
                <div class="menu_block">
                    <nav>
                        <ul class="sf-menu">
                            <li><a href="index1.html">Faqja Kryesore</a></li>
                            
                               <li><a href="rethnesh1.html">Rreth Nesh</a></li>
                     
                            <li><a href="identifikohu2.aspx">Adopto</a></li>
                            <li><a href="Identifikohu.aspx">Rapoto</a></li>
                            <li class="current"><a href="Regjistrim.aspx">Regjistrohu</a></li>
                            <li><a href="KURIOZITETE1.html">Kuriozitete </a></li>
                        </ul>
                    </nav>
                    <div class="clear"></div>
                </div>
            </div>
        </div>
    </header>
        <br />
        <br />
        
    <form id="form1" runat="server">
        <div  class="div1" style="background-color: #666666">
            
            <table>
                <h1 style="font-style: normal; color: #FFFFFF; font-size: small;">Ploteso te dhenat e meposhte per tu ber pjese e faqes</h1> 
                <br />
                <tr>
                    <td>
                        <asp:Label ID="emer1" runat="server" Text="Emër:" ForeColor="White"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="emer" placeholder="Emri..." runat="server" ></asp:TextBox>
                        <asp:RequiredFieldValidator class="validator" ID="rfvUser" ErrorMessage="<br/>Vendosni Emrin." ControlToValidate="emer" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="mbiemer1" runat="server" Text="Mbiemër:"  ForeColor="White"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="mbiemer" placeholder="Mbiemri..." runat="server"></asp:TextBox><asp:Label Style="color:red;" ID="ErrorMbiemri" runat="server">*</asp:Label>
                        <asp:RequiredFieldValidator class="validator" ID="RequiredFieldValidator1" ErrorMessage="<br/>Vendosni Mbiemrin." ControlToValidate="mbiemer" runat="server" />

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="username1" runat="server" Text="Username:" ForeColor="White"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="username" placeholder="Username..." runat="server"></asp:TextBox><asp:Label Style="color:red;" ID="Label2" runat="server">*</asp:Label>
                        <asp:RequiredFieldValidator class="validator" ID="RequiredFieldValidator2" ErrorMessage="<br/>Vendosni Username." ControlToValidate="username" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="mosha1" runat="server" Text="Mosha:" ForeColor="White"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="mosha" placeholder="Mosha..." runat="server"></asp:TextBox><asp:Label Style="color:red;" ID="Label1" runat="server">*</asp:Label>
                        <asp:RequiredFieldValidator class="validator" ID="RequiredFieldValidator3" ErrorMessage="<br/>Vendosni Moshën." ControlToValidate="mosha" runat="server" />

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="email1" runat="server" Text="E-mail:" ForeColor="White"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="email" placeholder="Email..." runat="server"></asp:TextBox><asp:Label Style="color:red;" ID="Label3" runat="server">*</asp:Label>
                        <asp:RequiredFieldValidator class="validator" ID="RequiredFieldValidator4" ErrorMessage="<br/>Vendosni Emailin." ControlToValidate="email" runat="server" />

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="fjalekalimi1" runat="server" Text="Fjalëkalimi:" ForeColor="White"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="fjalkalimi" placeholder="Fjalëkalimi..." TextMode="Password" runat="server"></asp:TextBox><asp:Label ID="Label4" Style="color:red;" runat="server">*</asp:Label>
                        <asp:RequiredFieldValidator class="validator" ID="RequiredFieldValidator5" ErrorMessage="<br/>Vendosni Fjalëkalimin." ControlToValidate="fjalkalimi" runat="server" />

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Konfirmo fjalëkalimin:" ForeColor="White"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox7" TextMode="Password" placeholder="Konfirmo fjalëkalimin..." runat="server"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox7" ErrorMessage="Fjalëkalimi nuk është i njëjtë," ToolTip="Fjalëkalimi duhet të jetë njësoj." ControlToValidate="fjalkalimi"></asp:CompareValidator>
                    </td>
                </tr>

                <tr>
                    <td></td>
                    <td>
                        <asp:Button class="button" ID="Regjistrim"  OnClick="Button1_Click" runat="server" Text="Rregjistrohu" BackColor="#FF9900" />
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
<br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
           
         
            <br />
            <br />
            <br />

        </div>
    </form>
</body>
</html>
