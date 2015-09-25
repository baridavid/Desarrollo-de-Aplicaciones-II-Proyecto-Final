@ModelType IEnumerable(Of Usuario)
@Code
ViewData("Title") = "Lista"
Layout = "~/Views/Shared/PrincipalAdmin.vbhtml"
End Code

<h2>Lista</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.nom1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.nom2)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.apePat)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.apeMat)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.user)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.password)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.correo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.administrador)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.nom1)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.nom2)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.apePat)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.apeMat)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.user)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.password)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.correo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.administrador)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id })
        </td>
    </tr>
Next

</table>
