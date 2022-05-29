<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="safhe khabar.aspx.cs" Inherits="main.UIL.safhe_khabar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
        <script src="https://code.jquery.com/jquery-3.5.1.min.js" integrity="sha256-9/aliU8dGd2tb6OSsuzixeV4y/faTqgFtohetphbbj0=" crossorigin="anonymous"></script>
        <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
        <script src="script/bootstrap/bootstrap.min.js"></script>
        <script src="script/jquery-3.6.0.min.js"></script>
        <link href="style/bootstrap css/bootstrap.min.css" rel="stylesheet" />
</head>
<body  style="background-color:#16a085; text-align:right ; font-size:18px>

     <form runat="server" style=" padding-bottom:10px;">
         <br />
    <div style="background:#203059 ;text-align:center; font-family:'B Nazanin'; border-color:white; color:white" >
        <h3>لیست خبرها </h3>
    </div>
         <br />
        <asp:GridView   BorderColor="black" BackColor="White" ForeColor="Black" Font-Bold="true"  ID="gridServiceAdmin" runat="server" AutoGenerateColumns="true" ShowFooter="true"  Width="98%" CellPadding="10" HorizontalAlign="Center" >
            
        </asp:GridView>


    </form>



</body>
</html>
