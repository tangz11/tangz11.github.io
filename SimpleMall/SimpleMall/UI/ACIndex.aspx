<%@ Page Language="C#" MasterPageFile="~/AccountCenter.master" AutoEventWireup="true" CodeFile="ACIndex.aspx.cs" Inherits="ACIndex" Title="会员中心" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="user_right_body">
   <div class="tit"><span>会员中心首页</span></div>
         <div class="main">
               <div class="welcome">
                  <div class="user_name">
                  <div><span></span> 欢迎您：<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></div>
                  <div>莅临<asp:Image ID="Image1" runat="server" ImageUrl="~/images/dd.gif" /></div>
                  </div>
                  <div class="last_time">您的上一次登录时间: 
                      <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label> </div>
                  <div class="submit"><div class="bg_01"><div class="bg_02">您最近30天内提交了0个订单</div></div></div>
                  <div class="hi">您现在拥有的Hi币：<span>0.00&nbsp;个Hi币</span>&nbsp;&nbsp;&nbsp;<span><ahref="http://www.hichoose.com/service/about_hi.html" target="_blank">什么是Hi币？</a></span></div>
                  <div class="hi">您现在拥有电子消费券：<span><a href="http://www.hichoose.com/user.php?act=e_coupons_detail">共计 0 个,价值 ￥0.00元</a></span></div>
               </div>                
        </div>
</div>        
</asp:Content>

