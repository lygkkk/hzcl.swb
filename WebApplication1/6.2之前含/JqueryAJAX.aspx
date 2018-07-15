<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JqueryAJAX.aspx.cs" Inherits="WebApplication1.JqueryAJAX" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script type="text/javascript">
        $(function() {
            $("#btnGet").click(function() {
                $.get("GetCurrenDate.ashx",
                    { "name": "张晶", "pwd": "zjkkk" },
                    function (data) {
                    alert(data);
                });
            });

            $("#btnPost").click(function() {
                $.post("GetCurrenDate.ashx",
                    { "name": "蓝跃钢", "pwd": "zjkkk" },
                    function(data) {
                        alert(data);
                    });
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="button" value="GET获取数据" id="btnGet"/>
            <input type="button" value="POST获取数据" id="btnPost"/>
        </div>
    </form>
</body>
</html>
