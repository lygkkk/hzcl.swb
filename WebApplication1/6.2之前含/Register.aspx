<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#msg").css("display", "none");

            $("#txtUserName").blur(function() {
                var userName = $(this).val();
                if (userName == "") {
                    alert("用户名不得为空！");
                } else {
                    $.post("CheckUserName",
                        { "name": userName },
                        function(data) {
                            $("#msg").css("display", "block");
                            $("#msg").text(data);
                        });
                }
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            用户名:<input type="text" name="txtName" id ="txtUserName"/><span id ="msg"></span><br/>
            密码:<input type="text" name="txtPwd"/><br/>
            <input type="submit" value="注册"/>
        </div>
    </form>
</body>
</html>
