<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="AnaSayfa.aspx.cs" Inherits="IsTakipWebUygulamasi.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="dashboard-stat blue">
        <div class="visual">
            <i class="icon-globe"></i>
        </div>
        <div class="details">
            <div class="number">
                <span>
                    <asp:Label ID="lblToplamIsSayisi" runat="server" Text='<%# Eval("ID") %>'></asp:Label></span>
            </div>
            <div class="desc">
                Toplam İş Sayısı
            </div>
        </div>
        <a class="more" href="ProjeDetay.aspx">İs Takip Uygulaması <i class="m-icon-swapright m-icon-white"></i>
        </a>
    </div>

    <div class="dashboard-stat green">
        <div class="visual">
            <i class="icon-globe"></i>
        </div>
        <div class="details">
            <div class="number">
                <span>
                    <asp:Label ID="lblTamamlanan" runat="server" Text='<%# Eval("ID") %>'></asp:Label></span>
            </div>
            <div class="desc">Tamamlanan İş Sayısı</div>
        </div>
        <a class="more" href="TamamlananIsDetayListesi.aspx">İş Takip Uygulaması <i class="m-icon-swapright m-icon-white"></i>
        </a>
    </div>

    <div class="dashboard-stat purple">
        <div class="visual">
            <i class="icon-globe"></i>
        </div>
        <div class="details">
            <div class="number">
                <span>
                    <asp:Label ID="lblDevamEden" runat="server" Text='<%# Eval("ID") %>'></asp:Label></span>
            </div>
            <div class="desc">Devam Eden İş Sayısı </div>
        </div>
        <a class="more" href="TamamlanmayanIsDetayListesi.aspx">İş Takip Uygulaması <i class="m-icon-swapright m-icon-white"></i>
        </a>
    </div>


    <div class="dashboard-stat yellow">
        <div class="visual">
            <i class="icon-globe"></i>
        </div>
        <div class="details">
            <div class="number">
                <asp:Label ID="lblCalismaGunSayisi" runat="server" Text=<%# Eval("ID") %>></asp:Label> </div>
            <div class="desc">Toplam Çalışılan Gün Sayısı</div>
        </div>
    </div>


    <div class="portlet box blue">
        <div class="portlet-title">
            <div class="caption"><i class="icon-bell"></i>Son 10 Yapılan İşlem </div>
            <div class="actions">
            </div>
        </div>
        <div class="portlet-body">
            <div style="position: relative; overflow: hidden; width: auto; height: 300px;" class="slimScrollDiv">
                <div class="scroller" style="height: 300px; overflow: hidden; width: auto;" data-always-visible="1" data-rail-visible="0">
                    <ul class="feeds">
                        <li>
                            <div class="col1">
                                <div class="cont">
                                    <div class="cont-col1">
                                    </div>
                                    <div class="cont-col2">
                                        <asp:Repeater ID="Repeater1" runat="server">
                                            <ItemTemplate>
                                                <div class="desc">
                                                    <div class="label label-sm label-success">
                                                        <i class="icon-briefcase"></i>
                                                    </div>
                                                    <span><%# Eval("YapilanIs") %></span>
                                                </div>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </div>
                                </div>
                            </div>
                        </li>

                    </ul>
                </div>
                <div style="background: none repeat scroll 0% 0% rgb(161, 178, 189); width: 7px; position: absolute; top: 111px; opacity: 0.4; display: block; border-radius: 7px; z-index: 99; right: 1px; height: 188.679px;" class="slimScrollBar"></div>
                <div style="width: 7px; height: 100%; position: absolute; top: 0px; display: none; border-radius: 7px; background: none repeat scroll 0% 0% rgb(51, 51, 51); opacity: 0.2; z-index: 90; right: 1px;" class="slimScrollRail"></div>
            </div>
            <div class="scroller-footer">
                <div class="pull-right">
                    <a href="ProjeDetay.aspx">Bütün Kayıtlara Git<i class="m-icon-swapright m-icon-gray"></i></a>&nbsp;
                </div>
            </div>
        </div>
    </div>
</asp:Content>
