<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="WebApp.account.member.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <script src="/assets/lib/jquery/jquery-1.11.0.js"></script>
    <script type="text/javascript">
        $(window).load(function () {
            // executes when complete page is fully loaded, including all frames, objects and images
            $('#btn').click(function() {
                alert('hhhhhhhhhhhhhh');
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input type="button" id="btn" value="Btn" />
    </div>
    </form>
</body>
</html>
