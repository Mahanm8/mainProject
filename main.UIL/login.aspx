<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="main.UIL.login" %>

<!DOCTYPE html>
<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" href="style.css" >
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<html xmlns="http://www.w3.org/1999/xhtml">
<html xmlns="http://www.w3.org/1999/xhtml">


<head runat="server">
    <title>
        login page
    </title>
    <link href="styles/login.css" rel="stylesheet" />
    <link rel="icon" href="raw/icon.png" />
</head>
<body style="background-color: #16a085 ;">
    <form id="form1" runat="server">
        <div  style="font-family:'B Roya';color:#2c3e50 " id="login">
        <h3 class="text-center pt-5">وبسایت خبری</h3>
        <div class="container">
            <div id="login-row" class="row justify-content-center align-items-center">
                <div id="login-column" class="col-md-6">
                    <div id="login-box" class="col-md-12">
                        <form id="login-form" class="form" action="" method="post">
                            <br />
                            <br />
                            
                   

                        </form>
                </div>
            </div>
        </div>
    </div>
        <div class="container" style="text-align:center;margin:auto;direction:rtl">
            <label for="uname"><b>نام کاربری</b></label>
            <asp:TextBox ID="txtUserName" runat="server" type="text" placeholder=" نام کاربری را وارد کنید" name="uname" required></asp:TextBox>

            <br />
            <br />

            <label for="psw"><b> &nbsp  &nbsp رمز عبور</b></label>
            <asp:TextBox ID="txtPassword" runat="server" type="password" placeholder="رمز عبور را وارد کنید" name="psw" required></asp:TextBox>

            <br />
            <br />

            <asp:Button ID="btnSubmit" runat="server" Text="ورود " BackColor="#203059" Font-Bold="true" ForeColor="White"  type="submit" OnClick="btnSubmit_Click"/>

        </div>
    </form>
</body>
</html>
