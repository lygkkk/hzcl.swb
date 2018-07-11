<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditCustomer.aspx.cs" Inherits="WebApplication1.EditCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            姓名:<input type="text" name="Name" value="<%= dt.Rows[0]["Name"] %>"/><br/>
            年龄:<input type="text" name="Age" value="<%= dt.Rows[0]["Age"] %>"/><br/>
            <input type="hidden" name="ID" value="<%= dt.Rows[0]["ID"] %>"/>
            <input type="submit" value="修改客户" />
        </div>
    </form>
</body>
</html>
