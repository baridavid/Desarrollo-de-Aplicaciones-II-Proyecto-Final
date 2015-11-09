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
                        <label><input type="checkbox" value="" checked />Recordar contraseña</label>
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

    <!-- Static navbar -->
    <div class="navbar navbar-inverse navbar-fixed-top">
        

            <div class="container-fluid">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="#">Enter@te</a>
                </div>
                <div id="navbar" class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="../Home/Index">Inicio</a></li>
                        <li><a href="#">Nacionales</a></li>
                        <li>@Html.ActionLink("Internacionales", "Index", "Internacionales")</li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Deportes <span class="caret"></span></a>
                            <ul class="dropdown-menu">
                                <li><a href="#">Locales</a></li>
                                <li><a href="#">Internacionales</a></li>
                                <li><a href="#">Por Deporte</a></li>
                                <li role="separator" class="divider"></li>
                                <li class="dropdown-header">Popular</li>
                                <li><a href="#">Juve</a></li>
                                <li><a href="#">Barcelona</a></li>
                            </ul>
                        </li>
                    </ul>
                    <ul class="nav navbar-nav navbar-right">
                        <li class="active"><a href="./">Negocios <span class="sr-only">(current)</span></a></li>
                        <li><a href="#" id="myBtn">Iniciar Sescion</a></li>
                        <li><a href="../navbar-fixed-top/">Log in</a></li>
                    </ul>
                </div><!--/.nav-collapse -->
            </div><!--/.container-fluid -->


        
    </div>
 </div> <!-- /container -->
