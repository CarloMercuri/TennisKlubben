<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TennisKlubben.Klub.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="/css/general.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="center-title">Welcome to our Tennis Club!</div>
            <div class="choice-parent">
                <div class="button-parent" style="margin-left: 35%">
                    <asp:Button ID="NewUserButton" runat="server" CssClass="choice-button" OnClick="btn_NewUserClick" Text="Register"/>
                </div>
                <div class="button-parent">
                    <%--<asp:Button ID="ExistingButton" runat="server" CssClass="choice-button" OnClick="btn_ExistingUser_Click" Text="Existing User"/>--%>
                    OR
                </div>
                <div class="input-parent">
                    <div style="font-size: 18px">Enter member code:</div>
                    <asp:TextBox ID="MemberCodeInputBox" CssClass="input-box" runat="server" ToolTip="Enter Member Code" AutoPostBack="true" OnTextChanged="input_Membercode_TextChange"></asp:TextBox>
                    <asp:Label ID="label_Membercode_Warning" runat="server" CssClass="warning-label"></asp:Label>
                </div>
                
            </div>
        </div>
    </form>
</body>
</html>
