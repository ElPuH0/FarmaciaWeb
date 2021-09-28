// const form=document.getElementById("miFormulario");
// form.addEventListener("submit", function(event){
//     form.reset()
// })

//Cambiar Tema - Color
var checkbox=document.querySelector('input[id=cambiarTema');
checkbox.addEventListener('change', function(){
    if(this.checked){
        trans()
        document.documentElement.setAttribute('temaActual', 'oscuro')
    }else{
        trans()
        document.documentElement.setAttribute('temaActual', 'claro')
    }
})
let trans=()=>{
    document.documentElement.classList.add('transition');
    window.setTimeout(()=>{
        document.documentElement.classList.remove('transition')
    }, 1000)
}

//Cambiar Tema - Guardar
var cambiarTema=document.getElementById('cambiarTema');
if(cambiarTema){
    iniciarTema();

    cambiarTema.addEventListener('change', function(event){
        reiniciarTema();
    });

    function iniciarTema(){
        var darkThemeSelected=(localStorage.getItem('cambiarTema')!==null && localStorage.getItem('cambiarTema')==='oscuro');
        cambiarTema.checked=darkThemeSelected;
        darkThemeSelected?document.body.setAttribute('temaActual', 'oscuro'):document.body.removeAttribute('temaActual');
    };

    function reiniciarTema(){
        if(cambiarTema.checked){
            document.body.setAttribute('temaActual', 'oscuro');
            localStorage.setItem('cambiarTema', 'oscuro');
        }else{
            document.body.removeAttribute('temaActual');
            localStorage.removeItem('cambiarTema');
        }
    };
}

//Tooltip
$(document).ready(function(){
    $('[data-toggle="tooltip"]').tooltip();   
});

//Gráfico - Claro
Highcharts.chart('grafico_claro', {
    chart: {
        type: 'scatter',
        margin: [70, 50, 60, 80],
        events: {
            click: function (e) {
                // find the clicked values and the series
                var x = Math.round(e.xAxis[0].value),
                    y = Math.round(e.yAxis[0].value),
                    series = this.series[0];

                // Add it
                series.addPoint([x, y]);

            }
        }
    },
    title: {
        text: 'Licencias vendidas en el mes de Junio'
    },
    subtitle: {
        text: 'Clientes Vs. Licencias'
    },
    accessibility: {
        announceNewData: {
            enabled: true
        }
    },
    xAxis: {
        gridLineWidth: 1,
        minPadding: 0.2,
        maxPadding: 0.2,
        maxZoom: 60
    },
    yAxis: {
        title: {
            text: 'Value'
        },
        minPadding: 0.2,
        maxPadding: 0.2,
        maxZoom: 60,
        plotLines: [{
            value: 0,
            width: 1,
            color: '#808080'
        }]
    },
    legend: {
        enabled: false
    },
    exporting: {
        enabled: false
    },
    plotOptions: {
        series: {
            lineWidth: 1,
            point: {
                events: {
                    click: function () {
                        if (this.series.data.length > 1) {
                            this.remove();
                        }
                    }
                }
            }
        }
    },
    series: [{
        name: 'Licencias vendidas',
        data: [[20, 20], [30, 50], [40, 25], [50, 80], [60, 220], [70, 50], [80, 70], [90, 250]]
        // data: [[20, 20], [80, 80], [30, 50], [40, 25], [80, 200], [100, 10]]
    }]
});

////Gráfico - Oscuro
//Highcharts.chart('grafico_oscuro', {
//    chart: {
//        type: 'scatter',
//        margin: [70, 50, 60, 80],
//        events: {
//            click: function (e) {
//                // find the clicked values and the series
//                var x = Math.round(e.xAxis[0].value),
//                    y = Math.round(e.yAxis[0].value),
//                    series = this.series[0];
//
//                // Add it
//                series.addPoint([x, y]);
//
//            }
//        }
//    },
//    title: {
//        text: 'Licencias vendidas en el mes de Marzo'
//    },
//    subtitle: {
//        text: 'Clientes Vs. Licencias'
//    },
//    accessibility: {
//        announceNewData: {
//            enabled: true
//        }
//    },
//    xAxis: {
//        gridLineWidth: 1,
//        minPadding: 0.2,
//        maxPadding: 0.2,
//        maxZoom: 60
//    },
//    yAxis: {
//        title: {
//            text: 'Value'
//        },
//        minPadding: 0.2,
//        maxPadding: 0.2,
//        maxZoom: 60,
//        plotLines: [{
//            value: 0,
//            width: 1,
//            color: '#808080'
//        }]
//    },
//    legend: {
//        enabled: false
//    },
//    exporting: {
//        enabled: false
//    },
//    plotOptions: {
//        series: {
//            lineWidth: 1,
//            point: {
//                events: {
//                    click: function () {
//                        if (this.series.data.length > 1) {
//                            this.remove();
//                        }
//                    }
//                }
//            }
//        }
//    },
//    series: [{
//        name: 'Licencias vendidas',
//        data: [[20, 20], [80, 80]]
//    }]
//});

function ddlselect(){
    var d=document.getElemetnById("ddselect");
    var displaytext=d.options[d.selectedIndex].text;
    document.getElementById("txtvalue").value=displaytext;
}

//Linkear
function linkear(){
    window.location.href=document.getElementById("UrlList").value;
}

//Acordeón
// $( function() {
//   var icons = {
//     header: "ui-icon-circle-arrow-e",
//     activeHeader: "ui-icon-circle-arrow-s"
//   };
//   $( "#accordion" ).accordion({
//     icons: icons
//   });
//   $( "#toggle" ).button().on( "click", function() {
//     if ( $( "#accordion" ).accordion( "option", "icons" ) ) {
//       $( "#accordion" ).accordion( "option", "icons", null );
//     } else {
//       $( "#accordion" ).accordion( "option", "icons", icons );
//     }
//   });
// } );
