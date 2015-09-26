@ModelType Usuario
@Code
    ViewData("Title") = "Login"
    Layout = "~/Views/Shared/Principal.vbhtml"
End Code

<h2>Login</h2>
@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True, "Login Fallo")
    @<div>
        <fieldset>
            <legend>Login</legend>
            <div class="editor-label">@Html.LabelFor(Function(model) model.user)</div>
            <div class="editor-field">
                @Html.TextBoxFor(Function(model) model.user)
                @Html.ValidationMessageFor(Function(model) model.user)
            </div>
            <div class="editor-label">@Html.LabelFor(Function(model) model.password)</div>
            <div class="editor-field">
                @Html.PasswordFor(Function(model) model.password)
                @Html.ValidationMessageFor(Function(model) model.password)
            </div>
            <input type="submit" value="Log In" />
        </fieldset>
    </div>

End Using
