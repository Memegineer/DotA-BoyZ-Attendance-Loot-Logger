<%@ Page Title="" Language="C#" MasterPageFile="~/DotABoyZ.Master" AutoEventWireup="true" CodeBehind="Raider.aspx.cs" Inherits="DotA_BoyZ_Attendance_Loot_Logger.Raider" %>
<asp:Content ID="Content" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div>
            <table style="margin-top: 20px; margin-left: 25px">
                <tr>
                    <td>
                        <asp:Label ID="lblRaid" runat="server" Text="Raid"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" Width="180px">
                            <asp:ListItem Value="1" Text="Blackwing Lair"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Molten Core"></asp:ListItem>
                            <asp:ListItem Value="3" Text="Onyxia's Lair"></asp:ListItem>
                            <asp:ListItem Value="4" Text="World Bosses"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblBoss" runat="server" Text="Boss"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtBoss" runat="server" Width="180px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblItem" runat="server" Text="Item"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtItem" runat="server" Width="180px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCharacter" runat="server" Text="Character"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCharacter" runat="server" Width="180px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSearch" runat="server" Text="SEARCH" Width="180px" BackColor="#0099ff" ForeColor="White" OnClick="btnSearch_Click"/>
                    </td>
                </tr>
            </table>
        </div>
        <div style="margin-left:25px; margin-top:20px">
            <asp:GridView ID="GridView1" runat="server" BorderWidth="1px" BorderStyle="Solid" BorderColor="Black"></asp:GridView>
        </div>
        
    </form>
</asp:Content>
