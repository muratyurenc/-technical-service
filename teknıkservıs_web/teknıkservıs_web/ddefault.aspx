<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ddefault.aspx.cs" Inherits="teknıkservıs_web.ddefault" %>

<!--Author: W3layouts
Author URL: http://w3layouts.com
License: Creative Commons Attribution 3.0 Unported
License URL: http://creativecommons.org/licenses/by/3.0/
-->
<!DOCTYPE html>
<html lang="zxx">
<head>
    <title>Polaroid Photography Category Bootstrap Responsive website Template | Home :: w3layouts</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta charset="utf-8" />
    <meta name="keywords" content="Polaroid Responsive web template, Bootstrap Web Templates, Flat Web Templates, Android Compatible web template, 
	SmartPhone Compatible web template, free WebDesigns for Nokia, Samsung, LG, Sony Ericsson, Motorola web design" />
    <script>
        addEventListener("load", function () {
            setTimeout(hideURLbar, 0);
        }, false);

        function hideURLbar() {
            window.scrollTo(0, 1);
        }
    </script>
    <!-- Custom Theme files -->
    <link href="web/css/bootstrap.css" type="text/css" rel="stylesheet" media="all">
    <link href="web/css/style.css" type="text/css" rel="stylesheet" media="all">
    <!-- font-awesome icons -->
    <link href="web/css/fontawesome-all.min.css" rel="stylesheet">
    <!-- //Custom Theme files -->
    <!-- online-fonts -->
    <link href="//fonts.googleapis.com/css?family=Source+Sans+Pro:200,300,400,600,700,900" rel="stylesheet">
    <!-- //online-fonts -->

</head>
<body>
    <div class="sidenav">
		<div class="row side_top">
		<div class="col-4 side_top_left">
			<img src="web/images/serv.png" alt="news image" class="img-fluid navimg">
		</div>
		<div class="col-8 side_top_right">
			<h6>TEKNIKSERVİS </h6>
			<p>ÜRÜN TAKIBI</p>
		</div>
		</div>
       <header>
			<div class="container-fluid px-md-5 ">
				<nav class="mnu mx-auto">
                    <label for="drop" class="toggle">Menu</label>
                    <input type="checkbox" id="drop">
						<ul class="menu">
							<li class="active"><a href="#home" class="scroll">ANASAYFA</a></li>
							 <li class="mt-sm-3"><a href="#about" class="scroll">HAKKIMIZDA</a></li>
							<li class="mt-sm-3"><a href="#gallery" class="scroll">ÜRÜNLER</a></li>
							<li class="mt-sm-3"><a href="#services" class="scroll">ÜRÜN TAKİBİ</a></li>
							<li class="mt-sm-3"><a href="#contact" class="scroll">İLETİŞİM</a></li>
                        </ul>
				</nav>
			</div>
		</header>
    </div>
    <div class="main" id="home">
        <div class="banner-text-w3ls">
            <div class="container">
                <div class="mx-auto text-center">
                    <h1>En Uygun Fiyatlarla Sizlerleyiz.
	<br></h1>
					<p class="banp mx-auto mt-3"> 24 Farklı Kategoride Yüzlerce Ürün İle Sizlerleyiz.  </p>
					<a class="btn btn-primary mt-lg-5 mt-3 agile-link-bnr" href="#about" role="button">Learn More</a>
                </div>
            </div>
        </div>
        </div>
				<!-- about -->
<section class="slide-wrapper" id="about">
	<h3 class="w3_head mb-5">HAKKIMIZDA </h3>
	<img src="images/1.jpg" class="img-fluid" alt="">
	<p class="iner mt-5"> 
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <%# Eval("METIN") %>
            </ItemTemplate>
        </asp:Repeater>
	</p>
</section>
<!-- //about -->
		<!-- news -->
       <div class="news" id="gallery">
		<div class="text-center">
			<h2 class="w3_head">ÜRÜNLER</h2>
				<table class="table table-bordered">
                   <tr>
                       <th>ID</th>
                       <th>ÜRÜN ADI</th>
                        <th>MARKA</th>
                        <th>SATIŞ FİYATI</th>
                    </tr>

              
                  <asp:Repeater ID="Repeater2" runat="server">
                      <ItemTemplate>
                          <tr> 
                             <td><%# Eval("ID")%></td>
                                <td><%# Eval("AD")%></td>
                                <td><%# Eval("MARKA")%></td>
                                <td><%# Eval("SATISFIYAT")%></td>
                  
                     </tr>
                      </ItemTemplate>
                  </asp:Repeater>
               
                    
               </table>
            </div>
           </div>
     <div class="wthree_pvtits-services align-w3" id="services">
        <div class="container">
            <div class="wthree_pvt_title text-center">
                <h3 class="w3_head">TEKNIKSERVİS
                </h3>
                <p class="main_p mb-5  text-center mx-auto"> TEKNİKLERİMİZ</p>
            </div>
            <div class="wthree_pvtits-services-row row">
                <div class="col-lg-4 col-md-6 wthree_sgrid py-sm-5 py-4">
                    <span class="fa fa-cog p-sm-4 p-2"></span>
                    <h4 class="my-3">HIZLI SERVİS</h4>
                </div>
                <div class="col-lg-4 col-md-6 wthree_sgrid  py-sm-5 py-4">
                    <span class="fa fa-refresh p-sm-4 p-2"></span>
                    <h4 class="my-3"> ADRESE TESLİM </h4>
                </div>
                <div class="col-lg-4 col-md-6 wthree_sgrid  py-sm-5 py-4">
                    <span class="fa fa-camera p-sm-4 p-2"></span>
                    <h4 class="my-3">TAM ZAMANKI ERİŞİM</h4>
                </div>
                <div class="col-lg-4 col-md-6 wthree_sgrid   py-sm-5 py-4">
                    <span class="fa fa-bell-o p-sm-4 p-2"></span>
                    <h4 class="my-3"> KARGO TAKIP </h4>
                </div>
                <div class="col-lg-4 col-md-6  wthree_sgrid  py-sm-5 py-4">
                    <span class="fa fa fa-smile-o p-sm-4 p-2"></span>
                    <h4 class="my-3">YORUMLAR </h4>
                </div>
                <div class="col-lg-4 col-md-6  wthree_sgrid   py-sm-5 py-4">
                    <span class="fa fa-plus-square-o  p-sm-4 p-2"></span>
                    <h4 class="my-3">İŞLER</h4>
                </div>
            </div>
        </div>
    </div>
    <!-- //services-->

		

<!-- contact -->
	 <section class="wedo" id="contact">
			<h3 class="w3_head mb-5">BİZE ULAŞIN </h3>
		   <p class="main_p mb-5  text-center mx-auto"> ŞİKAYETLERİNİZ VE GERİ DÖNÜŞ KUTUSU</p>
		   <div class="contact_grid_right mt-5 mx-auto text-center">
				<form action="#" method="post" runat="server">
					<div class="row contact_top">
						<div class="col-sm-6">
                            <asp:TextBox ID="TextBox1" runat="server"  placeholder="ADINIZ" ></asp:TextBox>
						</div>
						<div class="col-sm-6">
					   <asp:TextBox ID="TextBox2" runat="server"  placeholder="EMAİL" ></asp:TextBox>
						</div>
					</div>	
						   <asp:TextBox ID="TextBox3" runat="server"  placeholder="KONU" ></asp:TextBox>
						   <asp:TextBox ID="TextBox4" runat="server"  placeholder="MESAJINIZ" ></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="gönder" Height="51px" OnClick="Button1_Click" Width="144px" />
				</form>
			</div>
			<div class="cpy-right text-center">
			<div class="follow">
				<ul class="social_section_1info">
					<li><a href="#"><span class="fa fa-facebook"></span></a></li>
					<li><a href="#"><span class="fa fa-twitter"></span></a></li>
					<li><a href="#"><span class="fa fa-google-plus"></span></a></li>
					<li><a href="#"><span class="fa fa-dribbble"></span></a></li>
					
					<li><a href="#"><span class="fa fa-vimeo"></span></a></li>
					<li><a href="#"><span class="fa fa-linkedin"></span></a></li>
				</ul>
			</div>
				<p>© 2018 Polaroid. All rights reserved | Design by
					<a href="http://w3layouts.com"> W3layouts.</a>
				</p>
			</div>
	</section>
	 <!-- //contact -->


           </body>
    </html>

       
  
