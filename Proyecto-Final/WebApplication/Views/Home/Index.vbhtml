
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" http-equiv="content-type" content="width=device-width" charset="iso-8859-1" />
    <title>Portal de Noticias</title>
    <link rel="stylesheet" href="~/css/styles.css" type="text/css" />
  <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
  <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
  <style>
  .modal-header, h4, .close {
      background-color: #5cb85c;
      color:white !important;
      text-align: center;
      font-size: 30px;
  }
  .modal-footer {
      background-color: #f9f9f9;
  }
  </style>
</head>
<body>

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
              <input type="text" class="form-control" id="usrname" placeholder="Ingrese su usuario">
            </div>
            <div class="form-group">
              <label for="psw"><span class="glyphicon glyphicon-eye-open"></span> Contraseña</label>
              <input type="text" class="form-control" id="psw" placeholder="Ingrese su contraseña">
            </div>
            <div class="checkbox">
              <label><input type="checkbox" value="" checked>Recordar contraseña</label>
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
$(document).ready(function(){
    $("#myBtn").click(function(){
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
                <li><a href="#">Internacionales</a></li>
                <li><a href="#">Deportes</a></li>
                <li><a href="#">Negocios</a></li>
				<li><a href="#" id="myBtn">Iniciar Sesión</a></li>
            </ul>
        </div>
    </div>
    <div class="row1">
        <div class="row1l">
            <h2>Brown becomes new PM</h2><h3>Breaking News</h3>
            <img src="~/images/Gordon_Brown.jpg" alt="Gordon Brown" width="125" height="174" style="float:left; margin-right:6px;" />Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas sit amet metus. Nunc quam elit, posuere nec, auctor in, rhoncus quis, dui. Aliquam erat volutpat. Ut dignissim, massa sit amet dignissim cursus, quam lacus feugiat.<br />
            Lorem ipsum dolor sit amet, <em>consectetuer</em> adipiscing elit. Maecenas sit amet metus. Nunc quam elit, posuere nec, auctor in, rhoncus quis, dui. <a href="#">more &raquo;</a>
        </div>
        <div class="row1r">
            <div class="row1rl">
                <h2>Liverpool win Champions League</h2><h3>Sport</h3>
                <img src="~/images/Liverpool_Champions_League.jpg" alt="Liverpool" width="225" height="91" /> Lorem ipsum dolor sit amet, consectetuer adipiscing elit. <a href="#">more &raquo;</a>
            </div>
            <div class="row1rr">
                <h2>FTSE set to crash? </h2>
                <h3>Business</h3>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. <strong>Maecenas sit</strong> amet metus. Nunc quam elit, posuere nec, auctor in, rhoncus quis, dui. Aliquam erat volutpat. Ut dignissim, massa sit amet dignissim cursus, quam lacus feugiat. <a href="#">more &raquo;</a>
            </div>
        </div>
    </div>
    <br clear="all" />
    <div class="row2">
        <div class="row2l">
            <h2>Global warming to blame</h2><h3>Environment</h3>
            Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas sit amet metus. Nunc quam elit,<em><strong> posuere nec</strong></em>, auctor in, rhoncus quis, dui. Aliquam erat volutpat. Ut dignissim, massa sit amet dignissim cursus, quam lacus feugiat. <a href="#">more &raquo;</a>
        </div>
        <div class="row2r"><h2>Third divorce for rock star</h2><h3>Showbiz</h3>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas sit amet metus. Nunc quam elit, posuere nec, auctor in, rhoncus quis, dui. Aliquam erat volutpat. Ut dignissim, massa sit amet dignissim cursus, quam lacus feugiat. <a href="#">more &raquo;</a></div>
    </div>
    <br clear="all" />
    <div class="row3">
        <div class="row3l">
            <div class="row3ll"><h2>Opinion</h2>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas sit amet metus. Nunc quam elit, posuere nec, auctor in, rhoncus quis, dui. Aliquam erat volutpat. Ut dignissim, massa sit amet dignissim cursus, quam lacus feugiat. <a href="#">more &raquo;</a></div>
            <div class="row3lr"><h2>Letters</h2>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas sit amet metus. Nunc quam elit, posuere nec, auctor in, rhoncus quis, dui. Aliquam erat volutpat. Ut dignissim, massa sit amet dignissim cursus, quam lacus feugiat. <a href="#">more &raquo;</a></div>
        </div>
        <div class="row3r">
            <div class="row3rl"><h2>Travel</h2>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas sit amet metus. Nunc quam elit, posuere nec, auctor in, rhoncus quis, dui. Aliquam erat volutpat. Ut dignissim, massa sit amet dignissim cursus, quam lacus feugiat. <a href="#">more &raquo;</a></div>
            <div class="row3rr">
                <h2>Information</h2>
                This is my 2nd free template release. <strong>I hope you enjoy it!</strong><br />It is a very simple design and should be very easy to customise.<br />In the future i would like to release a more feature packed version.<br />Please leave any comments about this template <a href="http://www.mad-designs.org/free-website-template-daily-newspaper/">here &raquo;</a>
            </div>
        </div>
    </div>
    <br clear="all" />
    <div class="footer">&copy; Portal de Noticias | <em>Design by jarnedo</em> | <em>Proyecto como parte del curso de Desarrollo de Aplicaciones II </em></div>
    </div>
</body>
</html>
