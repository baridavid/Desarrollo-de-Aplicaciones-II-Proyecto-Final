@ModelType Usuario

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Details</title>
</head>
<body>
    <div>
        <h4>Usuario</h4>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                @Html.DisplayNameFor(Function(model) model.nom1)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.nom1)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.nom2)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.nom2)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.apePat)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.apePat)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.apeMat)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.apeMat)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.user)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.user)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.password)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.password)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.correo)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.correo)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.administrador)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.administrador)
            </dd>
    
        </dl>
    </div>
    <p>
        @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
        @Html.ActionLink("Back to List", "Index")
    </p>
</body>
</html>
