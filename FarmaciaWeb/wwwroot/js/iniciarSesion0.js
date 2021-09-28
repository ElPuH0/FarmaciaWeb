jQuery(document).ready(function($){
    $('#txtDNI').focus();
    $('#btnEntrar').on('click', function(){
        if($('#txtDNI').val()!="" & $('#txtContrasena').val()!=""){
            Validate($('#txtDNI').val(), $('#txtContrasena').val());
        }else{
            Swal.fire(
                'Error',
                'Existen campos vacíos',
                'error'
            );
        }
    });
    function Validate(dni, contrasena){
        var record={
            dni: dni,
            contrasena: contrasena
        };
        $.ajax({
            url: '/Persona/GetPersonas',
            async: false,
            type: 'POST',
            data: record,
            beforeSend: function(xhr, opts){},
            complete: function(){},
            success: function(data){
                if(data.status==true){
                    window.location.href="/Producto/List";
                }else if(data.status==false){
                    Swal.fire(
                        'Error',
                        data.message,
                        'error'
                    );
                }
            },
            error: function(data){
                Swal.fire(
                    'Error',
                    data.message,
                    'error'
                );
            }
        });
    }
});