<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TennisKlubben.Klub.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="/css/register.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-top: 100px; justify-content:center">
            <div style="font-weight: bold; font-size: 35px; text-align:center; margin-bottom: 50px;"> Register new user</div>
            <div class="input-parent" style="display: flex;">
                <div class="input-person">
                    <div>
                        <label class="input-label">Enter First Name:</label>
                    </div>
                    <div style="display: flex">
                         <asp:TextBox ID="input_FirstName" CssClass="input-box" runat="server" ToolTip="Enter First Name" OnTextChanged="input_Change"></asp:TextBox>
                         <asp:Label ID="warning_FirstName" runat="server" CssClass="warning-label" Visible="false">Cannot be empty!</asp:Label>
                    </div>

                    <div>
                        <label>Enter Last Name:</label>
                    </div>
                    <div style="display: flex">
                         <asp:TextBox ID="input_LastName" CssClass="input-box" runat="server" ToolTip="Enter Last Name" OnTextChanged="input_Change"></asp:TextBox>
                         <asp:Label ID="warning_LastName" runat="server" CssClass="warning-label" Visible="false"> Cannot be empty!</asp:Label>
                    </div>

                    <div>
                        <label>Enter Address:</label>
                    </div>
                    <div style="display: flex">
                         <asp:TextBox ID="input_Address" CssClass="input-box" runat="server" ToolTip="Enter Address" OnTextChanged="input_Change"></asp:TextBox>
                         <asp:Label ID="warning_Address" runat="server" CssClass="warning-label" Visible="false">Invalid Input!</asp:Label>
                    </div>

                    <div>
                        <label>Enter Telephone Number</label>
                    </div>
                    <div style="display: flex">
                         <asp:TextBox ID="input_PhoneNumber" TextMode="Number" CssClass="input-box" runat="server" ToolTip="Enter a phone number" OnTextChanged="input_Change"></asp:TextBox>
                         <asp:Label ID="warning_PhoneNumber" runat="server" CssClass="warning-label" Visible="false">Invalid Number</asp:Label>
                    </div>

                    <div>
                        <label>Enter Age:</label>
                    </div>
                    <div style="display: flex; margin-top:5px; font-size: 20px;">
                        Year: <asp:DropDownList ID="input_Year" runat="server" CssClass="input-date" AutoPostBack="true"/>
                        Month: <asp:DropDownList ID="input_Month" runat="server" CssClass="input-date" AutoPostBack="true" />
                        Day: <asp:DropDownList ID="input_Day" CssClass="input-date" AutoPostBack="true" runat="server"/>
                         <asp:Label ID="warning_Age" runat="server" CssClass="warning-label" Visible="false"></asp:Label>
                    </div>

                    <div>
                        <asp:Button ID="btn_Submit" runat="server" CssClass="submit-button" OnClick="btn_Submit_Click" Text="Submit"/>
                    </div>

              </div>

                <div id="div_CC" runat="server" class="input-card">
                    <div>
                        <label>Enter Credit Card Number:</label>
                    </div>
                    <div style="display: flex">
                         <asp:TextBox ID="input_CC_Number" TextMode="Number" CssClass="input-box" runat="server" ToolTip="Enter your credit card number" AutoPostBack="true" OnTextChanged="input_Change"></asp:TextBox>

                         <asp:Label ID="warning_CardNumber" runat="server" CssClass="warning-label" Visible="false">Invalid Card Number!</asp:Label>
                    </div>

                    <div>
                        <label>Enter Credit Card Owner:</label>
                    </div>
                    <div style="display: flex">
                         <asp:TextBox ID="input_CC_Owner" CssClass="input-box" runat="server" ToolTip="Enter the credit card holder's name" OnTextChanged="input_Change"></asp:TextBox>

                         <asp:Label ID="warning_CC_Owner" runat="server" CssClass="warning-label" Visible="false">Must fill in!</asp:Label>
                    </div>

                    <div style="display: flex;">
                        <div>
                            <div>
                                <label>Expiration Date</label>
                            </div>
                            <div style="display: flex;">
                                 <asp:TextBox ID="input_CC_ExpDay" TextMode="Number" MaxLength="2" CssClass="input-short" runat="server" ToolTip="Expiration Day" OnTextChanged="input_Change"></asp:TextBox>
                                                                
                                <div style="margin: 3px 5px 0px 5px; font-size: 25px;">
                                    /
                                </div>
                                 <asp:TextBox ID="input_CC_ExpMonth" TextMode="Number" MaxLength="2" CssClass="input-short" runat="server" ToolTip="Expiration Month"  OnTextChanged="input_Change"></asp:TextBox>
                            </div>
                        </div>
                        <div>
                             <div style="margin-left: 10px;">
                                <label>Check Code</label>
                            </div>
                            <div style="margin-left: 10px;">
                                 <asp:TextBox ID="input_CC_CheckCode" TextMode="Number" MaxLength="3" CssClass="input-medium" runat="server" ToolTip="CC Code" AutoPostBack="true" OnTextChanged="input_Change"></asp:TextBox>

                            </div>
                        </div>
                      
                    </div>
                    
                </div>
                
               

                
           </div>

        </div>
    </form>
</body>
</html>
