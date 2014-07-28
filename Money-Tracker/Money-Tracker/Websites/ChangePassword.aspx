<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="Money_Tracker.Websites.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/styleChangepassword.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="divContain">
            <p>Change your password here</p>
            <div>
                <span>
                    <label>Enter password</label>
                </span>
                <span>
                    <input type="password" id="txt_password" />
                </span>
            </div>
            <div>
                <span>
                    <label>Confirm password</label>
                </span>
                <span>
                    <input type="password" id="txt_conpwd" />
                </span>
            </div>
            <div>
                <button id="btnsubmit">Reset</button>
            </div>
        </div>
    </form>
</body>
</html>
