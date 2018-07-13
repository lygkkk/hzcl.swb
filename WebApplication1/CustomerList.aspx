<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerList.aspx.cs" Inherits="WebApplication1.CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>
                <%=strHtml %>
            </ul>
        </div>
        <div><%=PageNum %></div>
        <div class="pages"><a href="CustomerList.aspx?pageIndex=1">首页</a>　｜　
                           <a href="CustomerList.aspx?pageIndex=<%=CurrentPageIndex - 1 < 1 ? 1 : CurrentPageIndex - 1 %>">前页</a>　｜　
                           <a href="CustomerList.aspx?pageIndex=<%=CurrentPageIndex + 1 > PageCount ? PageCount : CurrentPageIndex + 1 %>">后页</a>　｜　
                           <a href="CustomerList.aspx?pageIndex=<%=PageCount%>">尾页</a>　｜　
                            页次:<%=CurrentPageIndex %> / <%=PageCount %>

        </div>
    </form>
</body>
</html>
