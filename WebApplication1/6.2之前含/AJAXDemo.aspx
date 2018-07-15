<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AJAXDemo.aspx.cs" Inherits="WebApplication1.AJAXDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script type="text/javascript">
        $(function ()
        {
            $("#GetCurrentDate").click(function ()
            {
                var xhr;
                if (XMLHttpRequest)
                {
                    xhr = new XMLHttpRequest();
                }
                xhr.open("get", "GetCurrenDate.ashx", true);
                xhr.send();
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
                
            })
        });
        //$(function() {
        //    $("#GetCurrentDate").click(function() {
        //        var xhr;
        //        if (XMLHttpRequest) {
        //            xhr = new XMLHttpRequest();
        //        }
        //        xhr.open("get", "GetCurrentDate.ashx", true);
        //        xhr.send();
        //        xhr.onreadystatechange = function() {
        //            if (xhr.readyState == 4) {
        //                if (xhr.status == 200) {
        //                    alert(xhr.responseText);
        //                }
        //            }
        //        };
        //    });
        //});
        
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="button" value="获取当前时间" id="GetCurrentDate"/>
        </div>
    </form>
</body>
</html>
