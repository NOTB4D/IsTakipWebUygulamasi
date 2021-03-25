<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="EserDetay.aspx.cs" Inherits="IsTakipWebUygulamasi.EserDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="portlet box red">
        <div class="portlet-title">
            <div class="caption"><i class="icon-cogs"></i>iş Planı Listesi</div>
            <div class="tools">
                <a href="javascript:;" class="collapse"></a>
            </div>
        </div>
        <div class="portlet-body">
            <table class="table table-hover">
                <thead>
                    <tr>
                        <th>Status</th>
                        <th>ProjeAdı</th>
                        <th>SorumluAdı</th>
                        <th>Yapılan İş</th>
                        <th>TahminiIsSuresi</th>
                        <th>Tamamlanma Yüzdesi</th>
                        <th>Başlama Tarihi</th>
                        <th>Bitiş Tarihi</th>
                    </tr>
                </thead>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tbody>
                            <tr>
                                <td><%# Eval("IslemTipi") %></td>
                                <td><%# Eval("ProjeAdi") %></td>
                                <td><%# Eval("SorumluAdi") %></td>
                                <td><%# Eval("YapilanIs") %></td>
                                <td><%# Eval("TahminiIsSuresi") %></td>
                                <td><%# Eval("TamamlanmaMiktari") %></td>
                                <td><%# Eval("BaslamaTarihi",("{0:MMMM d, yyyy}")) %></td>
                                <td><%# Eval("TeslimTarihi",("{0:MMMM d, yyyy}")) %></td>
                                <td><%# Eval("Aciklama") %></td>
                            </tr>
                        </tbody>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </div>
</asp:Content>
