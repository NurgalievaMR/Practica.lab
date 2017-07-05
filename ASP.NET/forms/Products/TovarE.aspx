﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="TovarE.aspx.cs" Inherits="IIS.АСУ_Склад.ТоварE" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>
<%-- Autogenerated section start [Register] --%>
<%-- Autogenerated section end [Register] --%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass %> <%= Constants.EditFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass %> <%= Constants.EditFormHeaderCssClass %>">Товар</h2>
        <div class="<%= Constants.FormToolbarCssClass %> <%= Constants.EditFormToolbarCssClass %> <%= Constants.StickyCssClass %>">
            <asp:ImageButton ID="SaveBtn" runat="server" SkinID="SaveBtn" OnClick="SaveBtn_Click" AlternateText="<%$ Resources: Resource, Save %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="SaveAndCloseBtn" runat="server" SkinID="SaveAndCloseBtn" OnClick="SaveAndCloseBtn_Click" AlternateText="<%$ Resources: Resource, Save_Close %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="CancelBtn" runat="server" SkinID="CancelBtn" OnClick="CancelBtn_Click" AlternateText="<%$ Resources: Resource, Cancel %>" />
        </div>
        <div class="<%= Constants.FormControlsCssClass %> <%= Constants.EditFormControlsCssClass %>">
            <%-- Autogenerated section start [Controls] --%>
<!-- autogenerated start -->
<div>
	<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlКодТовараLabel" runat="server" Text="Код товара" EnableViewState="False">
</asp:Label>
<ac:AlphaNumericTextBox CssClass="descTxt" ID="ctrlКодТовара" Type="Numeric" runat="server">
</ac:AlphaNumericTextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlНазваниеLabel" runat="server" Text="Название" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlНазвание" runat="server">
</asp:TextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlЕдиницаИзмеренияLabel" runat="server" Text="Единица измерения" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlЕдиницаИзмерения" runat="server">
</asp:TextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlОписаниеLabel" runat="server" Text="Описание" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlОписание" runat="server">
</asp:TextBox>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlЦенаLabel" runat="server" Text="Цена" EnableViewState="False">
</asp:Label>
<ac:DecimalTextBox CssClass="descTxt" ID="ctrlЦена" runat="server">
</ac:DecimalTextBox>

</div>

</div>
<!-- autogenerated end -->
            <%-- Autogenerated section end [Controls] --%>
        </div>
    </div>
</asp:Content>
