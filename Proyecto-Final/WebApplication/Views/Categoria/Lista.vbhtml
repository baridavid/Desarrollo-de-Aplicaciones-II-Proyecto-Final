@ModelType IEnumerable(Of Categoria)
@Code
ViewData("Title") = "Lista"
Layout = "~/Views/Shared/Principal.vbhtml"
End Code

<h2>Lista de Categorias</h2>

<p>
    @Html.ActionLink("Crear nueva categoria", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.nombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.descripcion)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.nombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.descripcion)
        </td>
        <td>
            @Html.ActionLink("Editar", "Edit", New With {.id = item.Id}) |
            @Html.ActionLink("Detalles", "Details", New With {.id = item.Id}) |
            @Html.ActionLink("Eliminar", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
