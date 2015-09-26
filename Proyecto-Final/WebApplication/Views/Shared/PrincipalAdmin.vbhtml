﻿
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
        /* Header */

        #splitterContainer { /* Main splitter element */
            height: 95%;
            width: 100%;
            margin: 0;
            padding: 0;
        }

        #leftPane {
            float: left;
            width: 15%;
            height: 100%;
            border-top: solid 1px #9cbdff;
            background: #c4dcfb;
            overflow: auto;
        }

        #rightPane { /*Contains toolbar and horizontal splitter*/
            float: right;
            width: 85%;
            height: 100%;
            background: #f4f4f4;
        }

        #rightSplitterContainer { /*horizontal splitter*/
            width: 100%;
            background: #FFFFFF;
            border-top: solid 1px #9cbdff;
        }

        #rightTopPane { /*Top nested in horizontal splitter */
            width: 100%;
            height: 100%;
            overflow: auto;
            background: #f4f4f4;
        }

        #rightBottomPane { /*Bottom nested in horizontal splitter */
            background: #f4f4f4;
            width: 100%;
            overflow: auto;
        }


        /* Splitbar styles; these are the default class names and required styles */
        .splitbarV {
            float: left;
            width: 6px;
            height: 100%;
            line-height: 0px;
            font-size: 0px;
            border-left: solid 1px #9cbdff;
            border-right: solid 1px #9cbdff;
            background: #cbe1fb url(images/panev.gif) 0% 50%;
        }


        .splitbuttonV {
            margin-top: -41px;
            margin-left: -4px;
            top: 50%;
            position: relative;
            height: 83px;
            width: 10px;
            background: transparent url(images/panevc.gif) 10px 50%;
        }

            .splitbuttonV.invert {
                margin-left: 0px;
                background: transparent url(images/panevc.gif) 0px 50%;
            }
    </style>
    <script type="text/javascript">

        $(document).ready(function () {
            $("#splitterContainer").splitter({ minAsize: 100, maxAsize: 300, splitVertical: true, A: $('#leftPane'), B: $('#rightPane'), slave: $("#rightSplitterContainer"), closeableto: 0 });
            $("#rightSplitterContainer").splitter({ splitHorizontal: true, A: $('#rightTopPane'), B: $('#rightBottomPane'), closeableto: 100 });
        });
    </script>
</head>
<body ng-app="myApp" ng-controller="userCtrl">
    @Html.Partial("~/Views/Shared/HeaderAdmin.vbhtml")
    @Html.Partial("~/Views/Shared/AsideAdmin.vbhtml")
    @RenderBody
</body>
</html>