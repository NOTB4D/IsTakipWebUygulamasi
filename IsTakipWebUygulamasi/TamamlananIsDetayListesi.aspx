<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="TamamlananIsDetayListesi.aspx.cs" Inherits="IsTakipWebUygulamasi.TamamlananIsDetayListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- BEGIN SAMPLE TABLE PORTLET-->
    <div class="portlet box blue">
        <div class="portlet-title">
            <div class="caption"><i class="icon-comments"></i>Tamamlanan İş Detay Listesi</div>
            <div class="tools">
                <a href="javascript:;" class="collapse"></a>
                
            </div>
        </div>
        <div class="portlet-body">
            <table class="table table-bordered table-hover">
                <thead>
                    <tr>
                        <th>Statu</th>
                        <th>Sorumlu Adı</th>
                        <th>Proje Adı</th>
                        <th>Yapılan İş</th>
                        <th>İş Süresi</th>
                        <th>Tamamlanma Yüzdesi</th>
                        <th>Başlama Tarihi</th>
                        <th>Bitiş Tarihi</th>
                    </tr>
                </thead>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tbody>
                            <tr class="active">
                                <td><%# Eval("IslemTipi") %></td>
                                <td><%# Eval("SorumluAdi") %></td>
                                <td><%# Eval("ProjeAdi") %></td>
                                <td><%# Eval("YapilanIs") %></td>
                                <td><%# Eval("TahminiIsSuresi") %></td>
                                <td><%# Eval("TamamlanmaMiktari")%></td>
                                <td><%# Eval("BaslamaTarihi") %></td>
                                <td><%# Eval("TeslimTarihi") %></td>
                            </tr>
                        </tbody>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </div>
    <!-- END SAMPLE TABLE PORTLET-->
</asp:Content>
