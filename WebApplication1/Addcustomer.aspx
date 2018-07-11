<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Addcustomer.aspx.cs" Inherits="WebApplication1.Addcustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>新增客户</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            姓名:<input type="text" name="Name"/><br/>
            年龄:<input type="text" name="Age"/><br/>
            <input type="hidden" name="isPostBack" value="1"/>
            <input type="submit" value="新增客户" />
        </div>
    </form>
</body>
</html>
