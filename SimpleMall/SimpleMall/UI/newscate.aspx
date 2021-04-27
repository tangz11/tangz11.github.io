<%@ Page Language="C#" MasterPageFile="~/zt.master" AutoEventWireup="true" CodeFile="newscate.aspx.cs" Inherits="catenews" Title="新闻分类" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
  <%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
    <link href="css/xstlye.css" rel="stylesheet" type="text/css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="x_all">
<div  class="x_left">
<div style="margin-bottom:7px;">
    <img src="images/index_top_right_01.jpg" /></div>
<div class="x_left_t2">

<ul>
<li><a href="newlist.aspx">七夕,NO孤品活动甜蜜上线</a> </li>
<li><a href="newlist.aspx">关于打折优惠 </a> </li>
<li><a href="newlist.aspx">关于哈球网</a>  </li>
<li><a href="newlist.aspx">购物小秘籍 </a> </li>
<li><a href="newlist.aspx">货到付款</a> </li> 
<li><a href="newlist.aspx">假期优惠活动 </a> </li>
<li><a href="newlist.aspx">售后服务 </a> </li>
<li><a href="newlist.aspx">关于Hi币 </a> </li>
<asp:Repeater ID="Repeater2" runat="server">  
  <ItemTemplate>
    <li><a href='newscate.aspx?uid=<%#Eval("_cateid")%>'><%#Eval("_catename")%></a></li>
  </ItemTemplate>  
</asp:Repeater>
<li><a href="newlist.aspx">友情链接 </a> </li>

</ul>

</div>
</div>
<div  class="x_right">
<div class="x_left_t2">
<div style=" margin-top:25px; text-align:center; font-size:16px; font-weight:bold;  ">
    新闻中心</div>
<div style="margin-right:37px; text-align:right;"> 
         <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
         　　　　<asp:TextBox ID="search" runat="server"></asp:TextBox>
         <asp:Button ID="Button1" runat="server" Text="搜索" onclick="Button1_Click1" />
    </div>
     <div > 
         <asp:Repeater ID="Repeater1" runat="server">
               <ItemTemplate>
           
               <table style="width: 100%">
                   <tr>
                       <td style="  text-align:right ; width:100px;" >
                           <%#Eval("name")%></td>
                       <td style="padding-left:22px;  width:200px;">
                         <a href='newshow.aspx?uid=<%#Eval("_id")%>'> <%#Common.DB.substr( Eval("_title").ToString(),13)%> </a></td>
                       <td style="padding-left:22px;  width:50px;">
                           <%#Eval("_click")%></td>
                       <td style="padding-left:22px;  width:150px;">
                          <%#Eval("_posttime")%></td>
                   </tr>
               </table>
           
            </ItemTemplate>
          </asp:Repeater>
      </div>
       
      <div style="clear:both;">  </div>
       <div>
           <webdiyer:AspNetPager ID="AspNetPager1" runat="server" FirstPageText="首页" 
               HorizontalAlign="Center" LastPageText="尾页" NextPageText="下一页" 
               PrevPageText="上一页" onpagechanging="AspNetPager1_PageChanging1">
           </webdiyer:AspNetPager>
       </div> 
<div class="line_x"></div>
</div>
<div class="x_left_t2">



</div>
</div>
<div class="clear"></div>
</div>
</asp:Content>

