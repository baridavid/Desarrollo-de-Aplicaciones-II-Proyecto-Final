@Code
    Layout = Nothing
End Code
<!DOCTYPE html>
<html>
<head>
    <meta name="viewport" http-equiv="content-type" content="width=device-width" charset="iso-8859-1" />
    <title>Portal de Noticias</title>
    <link rel="stylesheet" href="~/css/styles.css" type="text/css" />
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
    <style>
        .modal-header, h4, .close {
            background-color: #5cb85c;
            color: white !important;
            text-align: center;
            font-size: 30px;
        }

        .modal-footer {
            background-color: #f9f9f9;
        }
    </style>
</head>
<body>
    <!-- Cabecera de la Pagina -->
       @Html.Partial("~/Views/Shared/Header.vbhtml")
    <!-- Cuerpo de la Pagina -->         
       @RenderBody()
    <!-- Pie de Pagina -->    
       @Html.Partial("~/Views/Shared/Footer.vbhtml")
</body>
</html>
