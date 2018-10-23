@Imports Wirelesslink.Utilities

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="keywords" content="Wirelesslink Philippines, Wirelesslink, Automation and Security Inc., Ubiquiti, Routerboard, Mikrotik, Wireless, Ubiquiti Philippines">
    <meta name="google-site-verification" content="y6_pjeht2lgZ3h6Avp3eUJFqgrSqyEvEfEF-VTFt57M" />
    <title>@ViewBag.Title - Wirelesslink</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    <!-- Compiled and minified CSS -->
    @Styles.Render("https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.5/css/materialize.min.css")
    @Styles.Render("https://fonts.googleapis.com/icon?family=Material+Icons")
    @Styles.Render("http://fonts.googleapis.com/css?family=Roboto:300,400,500,700")
    @Styles.Render("https://fonts.googleapis.com/css?family=Raleway:400,200,700")
    @Styles.Render("https://maxcdn.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.min.css")
    <link type="text/css" rel="stylesheet" href="~/Content/lightslider.css" />
    <!-- Map Box CSS-->
    @Styles.Render("https://api.mapbox.com/mapbox.js/v2.2.1/mapbox.css")
    <!-- Map Box JS-->
    @Scripts.Render("https://api.mapbox.com/mapbox.js/v2.2.1/mapbox.js")

</head>
<body>
    <div class="wrapper">
      <div class="push-content">
            <header class="header">
                <div class="container">
                    <a href="#" class="header-icon" id="header-icon"></a>
                    <a href="#" class="header-logo">Wirelesslink</a>

                    <div class="menu">
                        <a href="~/Home">Home</a>
                        <a href="~/Ubiquiti">Ubiquiti</a>
                        <a href="~/Mikrotik">Mikrotik</a>
                        <a href="#">About</a>
                        <a href="~/Home/Contact">Contact</a>
                    </div>
                </div>
            </header>

        <div class="site-content">
            <div class="body-content">
                @RenderBody()

                <footer>
                    <div id="scroll" class="waves-effect waves-light">
                        <i class="material-icons">expand_less</i>
                    </div>
                    <div class="container">
                        <div class="row">
                            <div class="col-md-3 col-sm-6">
                                <h4>Quick Links</h4>
                                <ul>
                                    <li><a href="~/Home">Home</a></li>
                                    <li><a href="~/Ubiquiti">Ubiquiti</a></li>
                                    <li><a href="~/Mikrotik">Mikrotik</a></li>
                                    <li><a href="#">About Us</a></li>
                                    <li><a href="#">Contact Us</a></li>
                                </ul>
                            </div>
                            <div class="col-md-3 col-sm-6">
                                <h4>Information</h4>
                                <ul>
                                    <li><a href="#">Terms of Use</a></li>
                                    <li><a href="#">Privacy Policy</a></li>
                                    <li><a href="#">FAQs</a></li>
                                    <li><a href="#">About Us</a></li>
                                    <li><a href="#">Contact Us</a></li>
                                </ul>
                            </div>
                            <div class="col-md-6 col-sm-12">

                                    <h4>Address</h4>
                                    <ul>
                                        <li>If You have any Inquiries regarding our products You can visit us at # 36 S Veloso St. Brgy Salapan San Juan, Philippines or you can call us at <b>(02) 727 &mdash; 2727</b> / <b>(02) 738 &mdash; 1140</b>.</li>
                                    </ul>



                                    <h4>Newsletter</h4>
                                    <ul>
                                        <li>
                                            Subsribe to our Newsletter to get updates about new products release and special offer.
                                        </li>
                                        <li>
                                            <div class="form-group col-xs-8">
                                                <input type="email" class="form-control" id="exampleInputEmail1" placeholder="Email">
                                            </div>
                                            <div class="form-group col-xs-4">
                                                <button type="button" class="btn btn-default"><i class="material-icons">send</i></button>
                                            </div>
                                        </li>
                                    </ul>
                            </div>
                        </div>
                        
                        <div class="row">
                            <p>&copy; Copyright @DateTime.Now.Year &mdash; Wirelesslink</p>
                        </div>
                    </div>      
                </footer>
            </div>
        </div>
          <div class="site-body" id="site-body"></div>
      </div>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
    <!-- Compiled and minified JavaScript -->
    @Scripts.Render("https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.5/js/materialize.min.js")
    <script src="~/Scripts/lightslider.js"></script>
    
</body>
</html>
