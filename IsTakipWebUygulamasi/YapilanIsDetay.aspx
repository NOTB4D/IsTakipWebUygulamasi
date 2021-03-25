<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="YapilanIsDetay.aspx.cs" Inherits="IsTakipWebUygulamasi.YapilanIsDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- BEGIN SAMPLE TABLE PORTLET-->
    <div class="portlet box red">
        <div class="portlet-title">
            <div class="caption"><i class="icon-comments"></i>İş Takip Detay Bilgisi</div>
            <div class="tools">
                <a href="javascript:;" class="collapse"></a>
                <a href="#portlet-config" data-toggle="modal" class="config"></a>
                <a href="javascript:;" class="reload"></a>
                <a href="javascript:;" class="remove"></a>
            </div>
        </div>
        <div class="portlet-body">
            <table class="table table-bordered table-hover">
                <thead>
                    <tr>
                        <th>Statu</th>
                        <th>Proje Adı</th>
                        <th>Sorumlu Adı</th>
                        <th>Aciklama</th>
                    </tr>
                </thead>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tbody>
                            <tr>
                                <td class="active"><%# Eval("IslemTipi") %></td>
                                <td class="success"><%# Eval("ProjeAdi") %></td>
                                <td class="warning"><%# Eval("SorumluAdi") %></td>
                                <td class="danger"><%# Eval("Aciklama") %></td>
                            </tr>
                        </tbody>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </div>
</asp:Content>
