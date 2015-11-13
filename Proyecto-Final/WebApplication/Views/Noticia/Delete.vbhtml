@ModelType Noticia
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/Principal.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Noticia</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.titulo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.titulo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.resumen)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.resumen)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.detalle)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.detalle)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.fechaCreacion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.fechaCreacion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.fuente)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.fuente)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.imagen)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.imagen)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Categoria.nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Categoria.nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Puntuacion.puntuacion1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Puntuacion.puntuacion1)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
