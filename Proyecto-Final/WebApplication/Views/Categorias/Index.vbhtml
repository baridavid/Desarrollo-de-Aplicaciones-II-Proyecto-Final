@ModelType IEnumerable(Of Categoria)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/PrincipalAdmin.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
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
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
