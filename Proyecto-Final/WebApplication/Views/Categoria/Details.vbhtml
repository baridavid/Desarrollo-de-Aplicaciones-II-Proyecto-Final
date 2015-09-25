﻿@ModelType Categoria
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/Principal.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Categoria</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.descripcion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.descripcion)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Editar", "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink("Regresar", "Lista")
</p>