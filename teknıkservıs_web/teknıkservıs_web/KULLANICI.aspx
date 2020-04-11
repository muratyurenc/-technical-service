<%@ Page Title="" Language="C#" MasterPageFile="~/KULLANICI.Master" AutoEventWireup="true" CodeBehind="KULLANICI.aspx.cs" Inherits="teknıkservıs_web.KULLANICI1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Ürün seri no :" Font-Bold="True"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="ara" OnClick="Button1_Click" />

    <table class=" table table-bordered"; style="margin-top:15px">
        <tr>
           
              <th>AÇIKLAMA</th>
              <th>TARİH</th>
        </tr>
         <asp:Repeater ID="Repeater2" runat="server">
          <ItemTemplate>
        <tr>
            

            <td><%# Eval("ACIKLAMA") %></td>
             <td><%# Eval("TARIH") %></td>
        </tr>
        </ItemTemplate>
        </asp:Repeater>
    </table>


</asp:Content>

