// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    getDatatable('#table-contatos');
    getDatatable('#table-usuarios');

    $('.btn-total-contatos').click(function () {
        var usuarioId = $(this).attr('usuario-id');

        $.ajax({
            type: 'GET',
            url: '/Usuario/ListarContatosPorUsuarioId/' + usuarioId,
            success: function (result) {
                $("#listaContatosUsuario").html(result);
                $('#modalContatosUsuario').modal();
                getDatatable('#table-contatos-usuario');
            }
        });
    });
})

function getDatatable(id) {
    $(id).DataTable({
        "ordering": true,
        "paging": true,
        "searching": true,
        "oLanguage": {
            "sEmptyTable": "Nenhum registro encontrado na tabela",
            "sInfo": "Mostrar _START_ at&eacute; _END_ de _TOTAL_ registros",
            "sInfoEmpty": "Mostrar 0 at&eacute; 0 de 0 Registros",
            "sInfoFiltered": "(Filtrar de _MAX_ total registros)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Mostrar _MENU_ registros por pagina",
            "sLoadingRecords": "Carregando...",
            "sProcessing": "Processando...",
            "sZeroRecords": "Nenhum registro encontrado",
            "sSearch": "Pesquisar",
            "oPaginate": {
                "sNext": "Proximo",
                "sPrevious": "Anterior",
                "sFirst": "Primeiro",
                "sLast": "Ultimo"
            },
            "oAria": {
                "sSortAscending": ": Ordenar colunas de forma ascendente",
                "sSortDescending": ": Ordenar colunas de forma descendente"
            }
        }
    });
}


$('.close-alert').click(function() {
    $(".alert").hide('hide');
});

function horasTrabalhadas() {

    //Obtendo Valores da Chegada
    var startHour = parseInt(document.getElementById('chegadaHora').value);
    var startMin = parseInt(document.getElementById('chegadaMin').value);

    //Obtendo Valores da Saída
    var endHour = parseInt(document.getElementById('saidaHora').value);
    var endMin = parseInt(document.getElementById('saidaMin').value);

    //Validações dos Valores 
    if (startHour > 23 || startHour < 0 || isNaN(startHour)) {
        document.getElementById('chegadaHora').value = '!!'
    }

    else if (startMin > 59 || startMin < 0 || isNaN(startMin)) {
        document.getElementById('chegadaMin').value = '!!'
    }

    else if (endHour > 23 || endHour < 0 || isNaN(endHour)) {
        document.getElementById('saidaHora').value = '!!'
    }

    else if (endMin > 59 || endMin < 0 || isNaN(endMin)) {
        document.getElementById('saidaMin').value = '!!'
    }

    //Variáveis do Resultado
    var resultadoHora = endHour - startHour;
    var resultadoMin = endMin - startMin;

    //Lógica
    if (startHour > endHour)
        resultadoHora += 24;

    if ((startHour == endHour) && (startMin > endMin)) {
        resultadoHora += 24;
        resultadoMin = 60 - (startMin - endMin);
    }
    if (startMin > endMin) {
        resultadoHora -= 1
        resultadoMin = 60 - (startMin - endMin);
    }

    //Atribuindo o Resultados aos Elementos HTML
    document.getElementById('total').innerHTML = resultadoHora + ':' + resultadoMin;

}
