$(document).ready(function () {
    $(function () {
        $('[data-toggle="tooltip"]').tooltip();      
    })
});

function marcardesmarcar() {
    if ($("#Todos").prop('checked')) {
        $('#StrMarcarDesmarcar').html('Desmarcar Todos');
        $('.marcar').each(
           function () {
               $(this).prop('checked', true);
           }
        );
    } else {
        $('#StrMarcarDesmarcar').html('Escolher Todos');
        $('.marcar').each(
           function () {
               $(this).prop('checked', false);
           }
        );
    }
}
