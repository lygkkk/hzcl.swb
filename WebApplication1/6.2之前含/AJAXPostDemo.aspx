<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AJAXPostDemo.aspx.cs" Inherits="WebApplication1.AJAXPostDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script type ="text/javascript">
        $(function () {
            $("#btnPost").click(function ()
            {
                var xhr;
                if (XMLHttpRequest)
                {
                    xhr = new XMLHttpRequest();
                }

                xhr.open("post", "GetCurrenDate.ashx", true);
                xhr.setRequestHeader("content-Type", "application/x-www-form-urlencode");
                xhr.send("name=sasa");
                xhr.onreadystatechange = function ()
                {
                    if (xhr.readyState == 4)
                    {
                        if (xhr.status == 200)
                        {
                            alert(xhr.responseText);
                        }
                    }
                };
            });
        });

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type ="button" value ="获取数据" id ="btnPost" />
        </div>
    </form>
</body>
</html>
