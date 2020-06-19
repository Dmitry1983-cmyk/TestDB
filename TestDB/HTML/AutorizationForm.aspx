<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AutorizationForm.aspx.cs" Inherits="TestDB.HTML.AutorizationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <label >Введите логин : </label>
            <input type="text" id="login" runat="server" /><br/><br/>
            <label >Введите пароль</label>
            <input type="text" id="pass" runat="server"/>
            <br/><br/>
            <button id="btn_acept" type="submit">Войти</button>
        </div>
    </form>
</body>
</html>
