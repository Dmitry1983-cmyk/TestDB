<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegForm.aspx.cs" Inherits="TestDB.HTML.RegForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #name {
            margin-left: 29px;
        }
        #email {
            margin-left: 16px;
        }
        #login {
            margin-left: 11px;
        }
        #password {
            margin-left: 6px;
        }
        #btnreg {
            width: 182px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="reg_">
            <label>Имя</label>
            <input type="text" id="name" runat="server" /><br/><br/>
            <label>Телефон</label>
            <input type="text" id="phonenumber" runat="server" /><br/><br/>
            <label>Почта</label>
            <input type="text" id="email" runat="server" /><br/><br/>
            <label>Логин</label>
            <input type="text" id="login" runat="server" /><br/><br/>
            <label>Пароль</label>
            <input type="text" id="password" runat="server" /><br/><br/>
            <button type="submit" id="btnreg" runat="server">Регистрация</button>
        </div>
    </form>
</body>
</html>

