
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <title>Bootstrap Case</title>
    <meta name="viewport" content="width=device-width" charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css">
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <script src="js/jquery.min.js"></script>
    <script src="js/angular.min.js"></script>


    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script type="text/javascript" src="js/jquery-1.4.3.min.js"></script>
    <script type="text/javascript" src="js/splitter.js"></script>
    <style type="text/css" media="all">
        html, body {
            height: 100%;
            width: 100%;
            margin: 0;
            padding: 0;
            overflow: hidden;
        }

        #header {
            background: #c4dcfb;
            height: 5%;
        }

        #leftPane {
            float: left;
            width: 15%;
            height: 100%;
            border-top: solid 1px #9cbdff;
            background: #c4dcfb;
            overflow: auto;
        }
        #rightPane {
            float: left;
            width: 85%;
            height: 100%;
            overflow: hidden;
        }
    </style>
</head>
<body ng-app="myApp" ng-controller="userCtrl">
    @Html.Partial("~/Views/Shared/HeaderAdmin.vbhtml")
    @Html.Partial("~/Views/Shared/AsideAdmin.vbhtml")
    <div id="rightPane">@RenderBody()</div>  
</body>
</html>
