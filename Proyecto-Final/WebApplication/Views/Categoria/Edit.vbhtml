@ModelType Categoria
@Code
    ViewData("Title") = "Edit"
    Layout = "~/Views/Shared/Principal.vbhtml"
End Code

<h2>Edit</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>Categoria</h4>
        <hr />
        @Html.ValidationSummary(true)
        @Html.HiddenFor(Function(model) model.Id)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.nombre, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.nombre)
                @Html.ValidationMessageFor(Function(model) model.nombre)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.descripcion, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.descripcion)
                @Html.ValidationMessageFor(Function(model) model.descripcion)
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Regresar", "Lista")
</div>
