@ModelType IEnumerable(Of Noticia)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/Principal.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.titulo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.resumen)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.detalle)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.fechaCreacion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.fuente)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.imagen)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Categoria.nombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Puntuacion.puntuacion1)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.titulo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.resumen)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.detalle)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.fechaCreacion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.fuente)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.imagen)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Categoria.nombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Puntuacion.puntuacion1)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
