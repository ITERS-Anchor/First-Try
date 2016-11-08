<%@ Page Title="" Language="C#" MasterPageFile="~/shared/Site.Master" AutoEventWireup="true" CodeBehind="memberInfo.aspx.cs" Inherits="WebApp.account.memberInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
       <!-- 内容部分开始 -->


        
        <div class="row">
            <h3 class="member-tit f16 fb tit-family">我的商城</h3>
        </div>
        <div class="row">
            <!-- 左边栏 -->
            <div id="sidebar" class="col-lg-2">
                <div class="widget mb10">
                    <div class="panel-group" id="accordion">
                        <div class="panel">
                            <div class="panel-title">
                                <h5 class="fb pl10">
                                    <i class="pull-right m10 icon-main icon-up"></i><a data-toggle="collapse" data-toggle="collapse" data-parent="#accordion" href="#collapse-1">相关分类</a>
                                </h5>
                            </div>
                            <div id="collapse-1" class="panel-collapse collapse in">
                                <div class="meb-left-list">
                                    <ul>
                                        <li><a href="">我的订单</a></li>
                                        <li><a href="">我的购物车</a></li>
                                        <li><a href="">我的评价</a></li>
                                        <li><a href="">我的晒单</a></li>
                                        <li><a href="">我的关注</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class="panel">
                            <div class="panel-title">
                                <h5 class="fb pl10">
                                    <i class="pull-right m10 icon-main icon-down"></i><a data-toggle="collapse" data-toggle="collapse" data-parent="#accordion" href="#collapse-2">账户中心</a>
                                </h5>
                            </div>
                            <div id="collapse-2" class="panel-collapse collapse in">
                                <div class="meb-left-list">
                                    <ul>
                                        <li><a href="">编辑个人信息</a></li>
                                        <li><a href="">修改密码</a></li>
                                        <li><a href="">地址簿管理</a></li>
                                        <li><a href="">我的积分</a></li>
                                        <li><a href="">我的优惠宝</a></li>
                                        <li><a href="">我的优惠券</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class="panel">
                            <div class="panel-title">
                                <h5 class="fb pl10">
                                    <i class="pull-right m10 icon-main icon-down"></i><a data-toggle="collapse" data-toggle="collapse" data-parent="#accordion" href="#collapse-3">客户服务</a>
                                </h5>
                            </div>
                            <div id="collapse-3" class="panel-collapse collapse in">
                                <div class="meb-left-list">
                                    <ul>
                                        <li><a href="">退换货申请</a></li>
                                        <li><a href="">投诉反馈</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- 内容部分开始 -->
            <div id="content" class="col-lg-10">
                <div class="meb-content">
                    <div class="meb-avatar pull-left">
                        <img alt="" src="/assets/img/admin.png" /><br />
                        <input type="file" name="file" value="" multiple="multiple"/><br />
                        <input type="submit" value="Upload"/>
                    </div>
                    <div class="meb-infor pull-right">
                        <div class="meb-infor-title mb10"><b class="orange-font f14"><%=CurrentUser.LoginId%></b>&nbsp;&nbsp;欢迎您!</div>
                        <div class="account-security mb10">
                            账户安全：<b class="orange-font">中级</b> <i class="icon-main icon-security-4"></i>
                            <i class="icon-main icon-phone-bright"></i>手机已验证 
                            <i class="icon-main icon-email-bright"></i>邮箱已验证 
                            <i class="icon-main icon-regular-bright"></i>正常
                        </div>
                        <div class="information">
                            <ul>
                                <li class="information-tit">优惠宝：</li>
                                <li class="information-show"><span class="pull-right"><a href="">什么是优惠宝？</a></span><a href="">1000(=10元)</a></li>
                                <li class="information-tit">已完成：</li>
                                <li class="information-show"><a href="">全部订单(5)</a></li>
                                <li class="information-tit">待处理：</li>
                                <li class="information-show">
                                    <a href="">待付款(4)</a> &nbsp;
                                    <a href="">待发货(0)</a> &nbsp;
                                    <a href="">待收货(0)</a> &nbsp;
                                    <a href="">待评价(0)</a> &nbsp;  
                                    <a href="">待晒单(0)</a>
                                </li>
                                <li class="information-tit">总积分：</li>
                                <li class="information-show"><span class="pull-right"><a href="">积分规则</a></span><a href="">0</a></li>
                                <li class="information-tit last-li">会员等级：</li>
                                <li class="information-show last-li">
                                    <span class="pull-right">亲！您今天还没有签到哦！签到可获得<b class="red-font f14">10</b>优惠宝
                                        <button type="button" class="btn btn-warning btn-xs">我要签到</button></span>
                                    <a href="">49</a>&nbsp;<i class="icon-main icon-level-1"></i></li>
                            </ul>
                        </div>
                    </div>
                    <div class="clearfix"></div>
                </div>
            </div>
        </div>

        


        <!-- 内容部分结束 -->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="foot" runat="server">
</asp:Content>
