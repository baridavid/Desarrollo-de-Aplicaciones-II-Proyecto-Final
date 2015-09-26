@ModelType Usuario
@Code
    ViewData("Title") = "Create"
    Layout = "~/Views/Shared/PrincipalAdmin.vbhtml"
End Code

<h2>Create</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>Usuario</h4>
        <hr />
        @Html.ValidationSummary(true)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.nom1, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.nom1)
                @Html.ValidationMessageFor(Function(model) model.nom1)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.nom2, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.nom2)
                @Html.ValidationMessageFor(Function(model) model.nom2)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.apePat, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.apePat)
                @Html.ValidationMessageFor(Function(model) model.apePat)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.apeMat, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.apeMat)
                @Html.ValidationMessageFor(Function(model) model.apeMat)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.user, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.user)
                @Html.ValidationMessageFor(Function(model) model.user)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.password, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.password)
                @Html.ValidationMessageFor(Function(model) model.password)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.correo, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.correo)
                @Html.ValidationMessageFor(Function(model) model.correo)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.administrador, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.administrador)
                @Html.ValidationMessageFor(Function(model) model.administrador)
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
