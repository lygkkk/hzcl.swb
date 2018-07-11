<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customerInfo.aspx.cs" Inherits="WebApplication1.customerInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">
        window.onload = function () {
            var data = document.getElementsByClassName("delete");
            for (var i = 0; i < data.length; i++) {
                data[i].onclick = function() {
                    if (!confirm("确定要删除么？")) {
                        return false;
                    }
                }
            }
        };

    </script>
</head>
<body>
<form id="form1" runat="server">
    <a href="Addcustomer.aspx">新增客户</a>
    <table>
        <tr><th>序号</th><th>姓名</th><th>年龄</th><th>修改</th><th>详情</th><th>删除</th></tr>
    </table>
    <%=strHtml %>
</form>
</body>
</html>
