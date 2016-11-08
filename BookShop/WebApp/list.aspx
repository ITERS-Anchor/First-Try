<%@ Page Title="" Language="C#" MasterPageFile="~/shared/Site.Master" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="WebApp.list" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

            <!-- 列表页部分开始 -->
        <div class="row">
            <!-- 面包屑导航开始 -->
            <div class="col-lg-12">
                <ol class="breadcrumb bg-none">
                    <li><a href="#">首页</a></li>
                    <li><a href="#">运动 户外</a></li>
                    <li class="active">运动鞋</li>
                </ol>
            </div>
            <!-- 面包屑导航结束 -->
        </div>
        <div class="row">
            <!-- 左边栏开始 -->
            <div id="sidebar" class="col-lg-2">
                <!-- 相关分类模块 -->
                <div class="widget mb10">
                    <h5 class="widget-tit pl10 fb">相关分类</h5>
                    <div class="panel-group" id="accordion">
                        <div class="panel">
                            <div class="panel-title">
                                <h5 class="fb pl10">
                                    <a data-toggle="collapse" data-parent="#accordion" href="#collapseOne">电脑配件</a>
                                </h5>
                            </div>
                            <div id="collapseOne" class="panel-collapse collapse in">
                                <div class="panel-list">
                                    <ul>
                                        <li><a href="">CPU</a></li>
                                        <li><a href="">声卡/扩展卡</a></li>
                                        <li><a href="">刻录机/光驱</a></li>
                                        <li><a href="">主板</a></li>
                                        <li><a href="">刻录机/光驱</a></li>
                                        <li><a href="">声卡/扩展卡</a></li>
                                        <li><a href="">刻录机/光驱</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class="panel">
                            <div class="panel-title">
                                <h5 class="fb pl10">
                                    <a data-toggle="collapse" data-parent="#accordion" href="#collapseTwo">运动服</a>
                                </h5>
                            </div>
                            <div id="collapseTwo" class="panel-collapse collapse">
                                <div class="panel-list">
                                    <ul>
                                        <li><a href="">CPU</a></li>
                                        <li><a href="">声卡/扩展卡</a></li>
                                        <li><a href="">刻录机/光驱</a></li>
                                        <li><a href="">主板</a></li>
                                        <li><a href="">刻录机/光驱</a></li>
                                        <li><a href="">声卡/扩展卡</a></li>
                                        <li><a href="">刻录机/光驱</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class="panel">
                            <div class="panel-title">
                                <h5 class="fb pl10">
                                    <a data-toggle="collapse" data-parent="#accordion" href="#collapseThree">运动配件</a>
                                </h5>
                            </div>
                            <div id="collapseThree" class="panel-collapse collapse">
                                <div class="panel-list">
                                    <ul>
                                        <li><a href="">CPU</a></li>
                                        <li><a href="">声卡/扩展卡</a></li>
                                        <li><a href="">刻录机/光驱</a></li>
                                        <li><a href="">主板</a></li>
                                        <li><a href="">刻录机/光驱</a></li>
                                        <li><a href="">声卡/扩展卡</a></li>
                                        <li><a href="">刻录机/光驱</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- 商品推荐 -->
                <div class="widget mb10">
                    <h5 class="widget-tit pl10 fb">热门商品推荐</h5>
                    <ul class="widget-list-3">
                        <li>
                            <a href="">
                                <img class="center-block" alt="" src="assets/img/advertise/ad-2.jpg" /></a>
                            <div class="summary"><a href="">美的（Midea） MRO102C-4 反渗透 净水机</a></div>
                            <div class="price"><b class="f18">￥799</b> <span class="f12 ml10 red-font"><i class="icon-lower mr10">直降</i>已优惠 ￥481</span></div>
                        </li>
                        <li>
                            <a href="">
                                <img class="center-block" alt="" src="assets/img/advertise/ad-2.jpg" /></a>
                            <div class="summary"><a href="">美的（Midea） MRO102C-4 反渗透 净水机</a></div>
                            <div class="price"><b class="f18">￥799</b> <span class="f12 ml10 red-font"><i class="icon-lower mr10">直降</i>已优惠 ￥481</span></div>
                        </li>
                        <li>
                            <a href="">
                                <img class="center-block" alt="" src="assets/img/advertise/ad-2.jpg" /></a>
                            <div class="summary"><a href="">美的（Midea） MRO102C-4 反渗透 净水机</a></div>
                            <div class="price"><b class="f18">￥799</b> <span class="f12 ml10 red-font"><i class="icon-lower mr10">直降</i>已优惠 ￥481</span></div>
                        </li>
                    </ul>
                </div>
                <!-- 浏览记录推荐 -->
                <div class="widget mb10">
                    <h5 class="widget-tit pl10 fb">根据浏览记录为您推荐</h5>
                    <ul class="widget-list-3">
                        <li>
                            <a href="">
                                <img class="center-block" alt="" src="assets/img/advertise/ad-2.jpg" /></a>
                            <div class="summary tc"><span class="f12 ml10 red-font">%9会买 ：</span><a href="">美的（Midea） MRO102C-4 反渗透 净水机</a></div>
                            <div class="price tc"><b class="f18">￥799</b> </div>
                        </li>
                    </ul>
                    <div class="blue-font p10 pull-right"><a href="">查看更多推荐</a></div>
                    <div class="clearfix"></div>
                </div>
                <!-- 浏览记录 -->
                <div class="widget mb10">
                    <h5 class="widget-tit pl10 fb"><span class="pull-right f12 pr10 gray-font"><a href="">清除</a></span>浏览记录</h5>
                    <ul class="widget-list-2">
                        <li>
                            <div class="w-list-product">
                                <a href="">
                                    <img class="pull-left" alt="" src="" /></a>
                                <div class="summary"><a href="">阿迪达斯adidas女鞋跑步鞋-G61326</a></div>
                                <div class="price"><b>¥96</b></div>
                            </div>
                        </li>
                        <li>
                            <div class="w-list-product">
                                <a href="">
                                    <img class="pull-left" alt="" src="" /></a>
                                <div class="summary"><a href="">阿迪达斯adidas女鞋跑步鞋-G61326</a></div>
                                <div class="price"><b>¥96</b></div>
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
            <!-- 左边栏结束 -->
            <!-- 内容区域开始 -->
            <div id="content" class="col-lg-10">
                <div class="item-recommend">
                    <div class="list-item-title pl10 f14 tit-family "><i class="icon-main icon-recom mr5"></i>热卖推荐</div>
                    <div class="recommend-list">
                        <ul>
                            <li>
                                <a href="">
                                    <img alt="" class="pull-left center-block" src="assets/img/advertise/ad-2.jpg" /></a>
                                <div class="summary"><a href="">安踏Anta男鞋跑步鞋-11245507-4</a></div>
                                <div class="price"><b>¥227.00</b></div>
                                <button type="button" class="btn btn-danger btn-xs">立即抢购</button>
                            </li>
                            <li>
                                <a href="">
                                    <img alt="" class="pull-left center-block" src="assets/img/advertise/ad-2.jpg" /></a>
                                <div class="summary"><a href="">安踏Anta男鞋跑步鞋-11245507-4</a></div>
                                <div class="price"><b>¥227.00</b></div>
                                <button type="button" class="btn btn-danger btn-xs">立即抢购</button>
                            </li>
                            <li>
                                <a href="">
                                    <img alt="" class="pull-left center-block" src="assets/img/advertise/ad-2.jpg" /></a>
                                <div class="summary"><a href="">安踏Anta男鞋跑步鞋-11245507-4</a></div>
                                <div class="price"><b>¥227.00</b></div>
                                <button type="button" class="btn btn-danger btn-xs">立即抢购</button>
                            </li>
                            <li>
                                <a href="">
                                    <img alt="" class="pull-left center-block" src="assets/img/advertise/ad-2.jpg" /></a>
                                <div class="summary"><a href="">安踏Anta男鞋跑步鞋-11245507-4</a></div>
                                <div class="price"><b>¥227.00</b></div>
                                <button type="button" class="btn btn-danger btn-xs">立即抢购</button>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class="item-filter mt10">
                    <div class="list-item-title pl10 f14 tit-family "><b class="red-font f16">休闲鞋</b>---商品筛选</div>
                    <div class="filter-list">
                        <div class="list-body">
                            <div class="pull-left filter-left">种类：</div>
                            <div class="pull-right filter-right">
                                <div class="alert-sm fade in pull-left">
                                    <button type="button" class="close" data-dismiss="alert" aria-hidden="true">×</button>
                                    品牌：<b class="red-font">花花公子</b>
                                </div>
                                <div class="alert-sm fade in pull-left">
                                    <button type="button" class="close" data-dismiss="alert" aria-hidden="true">×</button>
                                    品牌：<b class="red-font">花花公子</b>
                                </div>
                            </div>
                            <div class="clearfix"></div>
                        </div>
                        <div class="list-body">
                            <div class="pull-left filter-left">种类：</div>
                            <div class="pull-right filter-right">
                                <ul>
                                    <li><a href="">日常休闲</a></li>
                                    <li><a href="">棉鞋</a></li>
                                    <li><a href="">工装鞋</a></li>
                                    <li><a href="">板鞋</a></li>
                                    <li><a href="">帆布鞋</a></li>
                                    <li><a href="">增高鞋</a></li>
                                    <li><a href="">驾车鞋</a></li>
                                    <li><a href="">安全鞋</a></li>
                                    <li><a href="">功能鞋</a></li>
                                    <li><a href="">其他</a></li>
                                </ul>
                            </div>
                            <div class="clearfix"></div>
                        </div>
                        <div class="list-body">
                            <div class="pull-left filter-left">价格：</div>
                            <div class="pull-right filter-right">
                                <ul>
                                    <li><a href="">日常休闲</a></li>
                                    <li><a href="">棉鞋</a></li>
                                    <li><a href="">工装鞋</a></li>
                                    <li><a href="">板鞋</a></li>
                                    <li><a href="">帆布鞋</a></li>
                                    <li><a href="">增高鞋</a></li>
                                    <li><a href="">驾车鞋</a></li>
                                    <li><a href="">安全鞋</a></li>
                                    <li><a href="">功能鞋</a></li>
                                    <li><a href="">其他</a></li>
                                </ul>
                            </div>
                            <div class="clearfix"></div>
                        </div>
                        <div class="list-body">
                            <div class="pull-left filter-left">鞋面材质：</div>
                            <div class="pull-right filter-right">
                                <ul>
                                    <li><a href="">日常休闲</a></li>
                                    <li><a href="">棉鞋</a></li>
                                    <li><a href="">工装鞋</a></li>
                                    <li><a href="">板鞋</a></li>
                                    <li><a href="">帆布鞋</a></li>
                                    <li><a href="">增高鞋</a></li>
                                    <li><a href="">驾车鞋</a></li>
                                    <li><a href="">安全鞋</a></li>
                                    <li><a href="">功能鞋</a></li>
                                    <li><a href="">其他</a></li>
                                </ul>
                            </div>
                            <div class="clearfix"></div>
                        </div>
                        <div class="list-body">
                            <div class="pull-left filter-left">尺码：</div>
                            <div class="pull-right filter-right">
                                <ul>
                                    <li><a href="">日常休闲</a></li>
                                    <li><a href="">棉鞋</a></li>
                                    <li><a href="">工装鞋</a></li>
                                    <li><a href="">板鞋</a></li>
                                    <li><a href="">帆布鞋</a></li>
                                    <li><a href="">增高鞋</a></li>
                                    <li><a href="">驾车鞋</a></li>
                                    <li><a href="">安全鞋</a></li>
                                    <li><a href="">功能鞋</a></li>
                                    <li><a href="">其他</a></li>
                                </ul>
                            </div>
                            <div class="clearfix"></div>
                        </div>
                        <div class="list-body">
                            <div class="pull-left filter-left">类型：</div>
                            <div class="pull-right filter-right">
                                <ul>
                                    <li><a href="">日常休闲</a></li>
                                    <li><a href="">棉鞋</a></li>
                                    <li><a href="">工装鞋</a></li>
                                    <li><a href="">板鞋</a></li>
                                    <li><a href="">帆布鞋</a></li>
                                    <li><a href="">增高鞋</a></li>
                                    <li><a href="">驾车鞋</a></li>
                                    <li><a href="">安全鞋</a></li>
                                    <li><a href="">功能鞋</a></li>
                                    <li><a href="">其他</a></li>
                                </ul>
                            </div>
                            <div class="clearfix"></div>
                        </div>
                    </div>
                </div>
                <div class="item-pro-list mt10">
                    <div class="list-item-title">
                        <div class="sort-left pull-left pl10">
                            <span>排序：</span>
                             <a <%=Sort==WebApp.SortType.SalesDesc?" class=\"active\"":string.Empty %> href="/list.aspx?page=<%=CurrentPage %>&cat=<%=CurrentCategory.Id %>&sort=3">销量 <span class="glyphicon glyphicon-arrow-down"></span></a>
                        <a href="/list.aspx?page=<%=CurrentPage %>&cat=<%=CurrentCategory.Id %>&sort=<%=Sort==WebApp.SortType.PriceDesc?2:1 %>">价格 
                            <%
                                if (Sort==WebApp.SortType.PriceDesc)
                                {                                    
                            %>
                            <span class="glyphicon glyphicon-arrow-up"></span>
                            <%
                                }
                                else if (Sort==WebApp.SortType.PriceAsc)
                                {
                            %>
                            <span class="glyphicon glyphicon-arrow-down"></span>
                            <%
                                }
                            %></a>
                        <a href="/list.aspx?page=<%=CurrentPage %>&cat=<%=CurrentCategory.Id %>&sort=5">上架时间 <span class="glyphicon glyphicon-arrow-down"></span></a>
                        </div>
                        <div class="sort-right pull-right">
                            <span><b class="red-font mr10">共<%=TotalCount %>件商品</b> <b class="red-font"><%=CurrentPage %></b>/<%=TotalPage %></span>
                            <button type="button" class="btn btn-default btn-xs"><i class="glyphicon glyphicon-chevron-left"></i>上一页</button>
                            <button type="button" class="btn btn-default btn-xs">下一页<i class="glyphicon glyphicon-chevron-right"></i></button>
                        </div>
                    </div>
                    <div class="clearfix"></div>
                    <div class="pro-list-show">
                        <ul>

                             <%
                                foreach (var item in ProductList)
                                {
                             %>
                                   <li>
                                <a class="img-container" href="detail.aspx?item=<%=item.Id %>">
                                    <img class="center-block" alt="" src="/content/books/<%=item.ISBN %>.jpg" /></a>
                                <div class="summary"><a href=""><%=item.Title %></a></div>
                                <div class="price"><span class="pull-right red-font">返129积分</span><b>￥<%=item.UnitPrice %></b></div>
                                <div class="list-show-eva"><i class="icon-main icon-eva-6"></i><a href="">已有215人评价</a></div>
                                <a href="/cart.aspx?item=<%=item.Id %>" class="btn btn-default btn-xs">加入购物车</a>
                                <button type="button" class="btn btn-default btn-xs">收藏</button>
                            </li>
                             <%   
                                 }
                             %>
                            
                           
                        </ul>
                    </div>
                </div>
                <%=BookShop.Utility.PagerHelper.RendPage("/list.aspx?page=@&cat="+CurrentCategory.Id,TotalPage,CurrentPage) %>
                <%--page bar--%>
                <%-- <div class="list-pagination">
                    <ul class="pagination">
                        <li class="previous disabled"><a href="#">&laquo;&laquo;</a></li>
                        <li class="disabled"><a href="#">&laquo;</a></li>
                        <li class="active"><a href="#">1</a></li>
                        <li><a href="#">2</a></li>
                        <li><a href="#">3</a></li>
                        <li><a href="#">4</a></li>
                        <li><a href="#">5</a></li>
                        <li><a href="#">&raquo;</a></li>
                        <li class="next"><a href="#">&raquo;&raquo;</a></li>
                    </ul>
                </div> --%>

            </div>
            <!-- 内容区域结束 -->
        </div>
        <!-- 列表页部分结束 -->

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="foot" runat="server">
</asp:Content>
