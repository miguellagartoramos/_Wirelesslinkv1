@Imports Wirelesslink.Utilities

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Wirelesslink</title>
<meta name="description" content="wirelesslink philippines is a supplier and service provider for Ubiquiti access point UAP|antenna|Mikrotik wireless router|electrical tools|cables|power box|two way digital radio|office desk|table|mobile accessories|usb cable electrical wire|cheapest Price!|distributor" />

    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    <!-- Compiled and minified CSS -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.5/css/materialize.min.css">
    <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">
    <link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Roboto:300,400,500,700" type="text/css">
    <link rel="stylesheet" type="text/css" href="https://fonts.googleapis.com/css?family=Raleway:400,200,700">
    <link rel="stylesheet" type="text/css" href="~/Content/animate.css">
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
                    <a href="~/Home" class="header-icon" id="header-icon"></a>
                    <a href="~/Home" class="header-logo">Wirelesslink</a>

                    <div class="menu">
                        <a href="~/Home">Home</a>
                        <a href="~/Ubiquiti">Ubiquiti</a>
                        <a href="~/Mikrotik">Mikrotik</a>
                        <a href="~/Hytera">Hytera</a>
                        <a href="#">About</a>
                        <a href="~/Home/Contact">Contact</a>
                    </div>
                </div>
            </header>

            <div class="site-content">
                <div class="body-content">
                    @RenderBody()

                </div>
            </div>
            <div class="site-body" id="site-body"></div>
        </div>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
    <!-- Compiled and minified JavaScript -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/0.97.5/js/materialize.min.js"></script>
    <script src="~/Scripts/wow.js"></script>
    <script src="~/Scripts/function.js"></script>


</body>
</html>
