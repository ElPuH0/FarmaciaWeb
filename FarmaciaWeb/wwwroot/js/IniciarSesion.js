jQuery(document).ready(function($){
    $('#dni').focus();
    $('#entrar').on('click', function(){
        if($('#dni').val()!="" & $('#contrasena').val()!=""){
            Validate($('#dni').val(), $('#contrasena').val());
            Swal.fire(
                'Success',
                'Usuario Creado con éxito',
                'success'
            );
        }else{
            Swal.fire(
                'Error',
                'Existen campos vacíos',
                'error'
            );
        }
    });
});