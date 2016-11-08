<%@ Page Title="" Language="C#" MasterPageFile="~/shared/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApp.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--header-->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <!--body-->
    <!-- 登录模块开始 -->
        <div class="row p30">
            <div class="col-lg-8">
                <!-- 左侧广告位 -->
                <img alt="" src="/assets/img/advertise/login-ban.gif" />
            </div>
            <div class="col-lg-4">
                <!-- 登录表单开始 -->
                <form role="form" action="login.aspx" method="post" class="login-form f14">
                    <div class="form-group">
                        <label for="username">邮箱/用户名/已验证手机</label>
                        <input type="text" class="form-control" name="username" placeholder="邮箱/用户名/已验证手机" />
                    </div>
                    <div class="form-group">
                        <label for="password">密码</label>
                        <input type="password" class="form-control" name="password" placeholder="密码" />
                    </div>
                    <div class="form-group">
                        <label for="vcode">验证码</label>
                        <div class="input-group">
                            <input type="text" class="form-control" name="vcode" placeholder="验证码">
                            <span class="input-group-addon" style="padding: 0 2px; cursor: pointer">
                                <img id="vcode_img" src="/handler/validationcode.ashx" data-src="/handler/validationcode.ashx" width="100" height="32" alt="验证码" title="点击切换验证码">
                            </span>
                        </div>
                    </div>
                    <div class="checkbox f12">
                        <label>
                            <input type="checkbox" name="remember_me"/>记住我</label>
                        <span class="pull-right"><a href="findme.aspx">忘记密码？</a>&nbsp;<a href="register.aspx">免费注册</a></span>
                    </div>
                    <input type="hidden" name="redirect" value="<%=Request["redirect"] %>"" />
                    <button type="submit" class="btn btn-danger btn-block f16">登 录</button>
                    <span style="color:red;font-size:18px" ><%=ErrorMsg%></span> 
                </form>
                <!-- 登录表单结束 -->
            </div>
        </div>
        <!-- 登录模块结束 -->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="foot" runat="server">
    <!--footer-->
    <script>
        $('#vcode_img').click(function() {
            //$(this).attr('src', '/handler/validationcode.ashx?'+Math.random());
            $(this).attr('src', $(this).data('src') + '?' + Math.random());
            //data('src')来自data-src
        });
    </script>
</asp:Content>