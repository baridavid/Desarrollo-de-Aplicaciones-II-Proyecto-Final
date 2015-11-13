@ModelType Noticia
@Code
    ViewData("Title") = "Create"
    Layout = "~/Views/Shared/Principal.vbhtml"
End Code

<h2>Create</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>Noticia</h4>
        <hr />
        @Html.ValidationSummary(true)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.titulo, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.titulo)
                @Html.ValidationMessageFor(Function(model) model.titulo)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.resumen, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.resumen)
                @Html.ValidationMessageFor(Function(model) model.resumen)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.detalle, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.detalle)
                @Html.ValidationMessageFor(Function(model) model.detalle)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.fechaCreacion, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.fechaCreacion)
                @Html.ValidationMessageFor(Function(model) model.fechaCreacion)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.fuente, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.fuente)
                @Html.ValidationMessageFor(Function(model) model.fuente)
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
            @Html.LabelFor(Function(model) model.fkPuntuacion, "fkPuntuacion", New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("fkPuntuacion", String.Empty)
                @Html.ValidationMessageFor(Function(model) model.fkPuntuacion)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.fkCategoria, "fkCategoria", New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("fkCategoria", String.Empty)
                @Html.ValidationMessageFor(Function(model) model.fkCategoria)
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
