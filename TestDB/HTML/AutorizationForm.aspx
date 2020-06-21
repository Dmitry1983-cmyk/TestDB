<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AutorizationForm.aspx.cs" Inherits="TestDB.HTML.AutorizationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #btn_acept {
            width: 230px;
        }
        #chek {
            width: 21px;
        }
    </style>
</head>
<body style="width: 1182px">
    <form id="form1" runat="server">
        <div style="height: 180px">
             <label >Введите логин : </label>
            <input type="text" id="login" runat="server" /><br/><br/>
            <label >Введите пароль</label>
            <input type="text" id="pass" runat="server"/>
            <br/><br/>
           <%--<button id="btn_acept" type="submit">Войти</button><br/><br/>
            <button type="submit" name="btn_reg" value="registr" style="width: 230px">Регистрация</button>--%>
             <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Вход" Width="240px" /><br/><br/>
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Регистрация" Width="240px" />
            
            
        </div>
    </form>
</body>
</html>
