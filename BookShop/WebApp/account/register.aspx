<%@ Page Title="" Language="C#" MasterPageFile="~/shared/Site.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebApp.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
            <!-- 注册模块开始 -->
        <div class="row p30">
            <div class="col-lg-8">
                <!-- 左侧广告位 -->                
                <img src="/assets/img/advertise/login-ban.gif" />
            </div>
            <div class="col-lg-4">
                <!-- 注册表单开始 -->
                <form role="form" action="register.aspx" method="post" class="login-form f14">
                    <div class="form-group">
                        <label for="username">邮箱/用户名/已验证手机</label>
                        <input type="text" class="form-control" name="username" placeholder="邮箱/用户名/已验证手机">
                    </div>
                    <div class="form-group">
                        <label for="password">密码</label>
                        <input type="password" class="form-control" name="password" placeholder="密码">
                    </div>
                    <div class="form-group">
                        <label for="confirm">确认密码</label>
                        <input type="password" class="form-control" name="confirm" placeholder="确认密码">
                    </div>
                    <div class="form-group">
                        <label for="vcode">验证码</label>
                        <div class="input-group">
                            <input type="text" class="form-control" name="vcode" placeholder="验证码">
                            <span class="input-group-addon" style="padding:0 2px;cursor:pointer">
                                <img id="vcode_img" src="/handler/validationcode.ashx" data-src="/handler/validationcode.ashx" width="100" height="32" alt="验证码" title="点击切换验证码">
                            </span>
                        </div>
                    </div>
                    <div class="checkbox f12">
                        <label>
                            <input name="is_checked" type="checkbox">
                            我已阅读并同意 &nbsp;<span class="blue-font"><a href="">《传智用户注册协议》</a></span>
                        </label>
                    </div>
                    <button type="submit" class="btn btn-danger btn-block f16">立即注册</button>
                    <span style="color:red;font-size:18px" ><%=ErrorMsg%></span> 
                </form>
                <!-- 注册表单结束 -->
            </div>
        </div>
        <!-- 注册模块结束 -->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="foot" runat="server">
    <script>
        $('#vcode_img').click(function() {
            //$(this).attr('src', '/handler/validationcode.ashx?'+Math.random());
            $(this).attr('src', $(this).data('src') + '?' + Math.random());
            //data('src')来自data-src
        });
    </script>
</asp:Content>
