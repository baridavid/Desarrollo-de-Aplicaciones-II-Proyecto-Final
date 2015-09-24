 <!-- Modal -->
<div class="modal fade" id="myModal" role="dialog">
    <div class="modal-dialog">
        <!-- Modal content-->
        <div class="modal-content">
            <div class="modal-header" style="padding:35px 50px;">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4><span class="glyphicon glyphicon-lock"></span> Iniciar Sesión</h4>
            </div>
            <div class="modal-body" style="padding:40px 50px;">
                <form role="form">
                    <div class="form-group">
                        <label for="usrname"><span class="glyphicon glyphicon-user"></span> Usuario</label>
                        <input type="text" class="form-control" id="usrname" placeholder="Ingrese su usuario" />
                    </div>
                    <div class="form-group">
                        <label for="psw"><span class="glyphicon glyphicon-eye-open"></span> Contraseña</label>
                        <input type="text" class="form-control" id="psw" placeholder="Ingrese su contraseña" />
                    </div>
                    <div class="checkbox">
                        <label><input type="checkbox" value="" checked=checked />Recordar contraseña</label>
                    </div>
                    <button type="submit" class="btn btn-success btn-block"><span class="glyphicon glyphicon-off"></span> INGRESAR</button>
                </form>
            </div>
            <div class="modal-footer">
                <button type="submit" class="btn btn-danger btn-default pull-left" data-dismiss="modal"><span class="glyphicon glyphicon-remove"></span> Cancelar</button>
                <p>¿No eres miembro? <a href="#">Unirse</a></p>
                <p>¿Olvidó la contraseña? <a href="#">¿Contraseña?</a></p>
            </div>
        </div>
    </div>
</div>
<script>
    $(document).ready(function () {
        $("#myBtn").click(function () {
            $("#myModal").modal();
        });
    });
</script>
<div class="container">
    <div class="header">
        <div class="topl"><h1><em>Entér@te</em></h1></div>
        <div class="topr">
            <ul>
                <li><a href="#">Nacionales</a></li>
                <!--li><a href="#">Internacionales</a><li-->
                <li>@Html.ActionLink("Internacionales", "Index", "Internacionales")</li>
                <li>@Html.ActionLink("Deportes", "Index", "Deportes")</li>
                <!--li><a href="#">Deportes</a></li-->
                <li><a href="#">Negocios</a></li>
                <li><a href="#" id="myBtn">Iniciar Sesión</a></li>
            </ul>
        </div>
    </div>
</div>
</html>