@ModelType Categoria
@Code
    ViewData("Title") = "Create"
    Layout = "~/Views/Shared/PrincipalAdmin.vbhtml"
End Code

<h2>Create</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>Categoria</h4>
        <hr />
        @Html.ValidationSummary(true)
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
            @Html.LabelFor(Function(model) model.imagen, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.imagen)
                @Html.ValidationMessageFor(Function(model) model.imagen)
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>
<script src="~/Scripts/jquery-1.10.2.min.js"></script>
<script src="~/Scripts/jquery.validate.min.js"></script>
<script src="~/Scripts/jquery.validate.unobtrusive.min.js"></script>
