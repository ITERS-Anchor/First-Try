<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="categories.aspx.cs" Inherits="WebApp.categories" %>
<%@ Import Namespace="WebApp" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <% RenderCategories = (categories) => { %>
    <ul>
        <% foreach(Category item in categories){ %>
        <li><%= item.Name %>
        <% RenderCategories(item.Children); %>
       </li>
        <% } %>
    </ul>
    <% }; %>
    <%--<% RenderCategories = delegate(IList<Category> categories)
       {
           Response.Write("<ul>");
           foreach (Category item in categories)
           {
               Response.Write("<li>" + item.Name);
               RenderCategories(item.Children);
               Response.Write("</li>");
           }
       }; %>--%>

    <% RenderCategories(Categories); %>

    <%--<%=RenderCategory(Categories) %>--%>
    
</body>
</html>
