<%@ Page Title="" Language="C#" MasterPageFile="~/DotABoyZ.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DotA_BoyZ_Attendance_Loot_Logger.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <title>DotA BoyZ Login</title>
    <style>
        body {
            background-color:black;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <form id="form1" runat="server">
       <div>
           <table style="margin-top:10px;border:5px solid white; margin-left: 40%">
               <tr>
                   <td>
                        <asp:Label ID="lblUsername" runat="server" Text="Username" Font-Bold="true" ForeColor="White"></asp:Label>
                   </td>

                   <td>
                       <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                   </td>
               </tr>

               <tr>
                   <td>
                       <asp:Label ID="lblPassword" runat="server" Text="Password" Font-Bold="true" ForeColor="White"></asp:Label>
                   </td>

                   <td>
                       <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                   </td>
               </tr>

               <tr>
                   <td></td>
                   <td>
                       <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                   </td>
               </tr>
           </table>
       </div>
        
        
        

   </form>

</asp:Content>
