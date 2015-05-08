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


function carregaFormulario() {
    var TipoLogin  = $('#TipoLogin').val();
    var TipoPessoa = $('#TipoPessoa').val();


    if (TipoLogin != "") {
        $('#Teste').show('slow');
    } else {
        $('#Teste option[value=""]').attr('selected', 'selected');
        $('#CPF').val('');
        $('#CNPJ').val('');
        $('#NomePessoa').val('');
        $('#NomeEmpresa').val('');
        $('#Email').val('');
        $('#Telefone1').val('');
        $('#Telefone2').val('');
        $('#CEP').val('');
        $('#Rua').val('');
        $('#NumeroEnd').val('');
        $('#Complemento').val('');
        $('#Bairro').val('');
        $('#Cidade').val('');
        $('#UF option[value=""]').attr('selected', 'selected');

        $('#Teste').hide('fast');
        $('#divCPF').hide('fast');
        $('#divCNPJ').hide('fast');
        $('#divNome').hide('fast');
        $('#divNomeEmpresa').hide('fast');
        $('#divEmail').hide('fast');
        $('#divTelefone').hide('fast');
        $('#divCelular').hide('fast');
        $('#divCEP').hide('fast');
        $('#divRua').hide('fast');
        $('#divNumero').hide('fast');
        $('#divComplemento').hide('fast');
        $('#divBairro').hide('fast');
        $('#divCidade').hide('fast');
        $('#divUF').hide('fast');
        return false;
    }

    if (TipoPessoa == "PF") {
        $('#divCNPJ').hide('slow');
        $('#CNPJ').val('');
        $('#divCPF').show('slow');
        $('#divNome').show('slow');
        $('#divNomeEmpresa').show('slow');
        $('#divEmail').show('slow');
        $('#divTelefone').show('slow');
        $('#divCelular').show('slow');
        $('#divCEP').show('slow');
        $('#divRua').show('slow');
        $('#divNumero').show('slow');
        $('#divComplemento').show('slow');
        $('#divBairro').show('slow');
        $('#divCidade').show('slow');
        $('#divUF').show('slow');

    } else if(TipoPessoa == "PJ") {
        $('#divCPF').hide('slow');
        $('#CPF').val('');
        $('#divCNPJ').show('slow');
        $('#divNome').show('slow');
        $('#divNomeEmpresa').show('slow');
        $('#divEmail').show('slow');
        $('#divTelefone').show('slow');
        $('#divCelular').show('slow');
        $('#divCEP').show('slow');
        $('#divRua').show('slow');
        $('#divNumero').show('slow');
        $('#divComplemento').show('slow');
        $('#divBairro').show('slow');
        $('#divCidade').show('slow');
        $('#divUF').show('slow');

    } else if (TipoPessoa == "") { 
        $('#CPF').val('');
        $('#CNPJ').val('');
        $('#NomePessoa').val('');
        $('#NomeEmpresa').val('');
        $('#Email').val('');
        $('#Telefone1').val('');
        $('#Telefone2').val('');
        $('#CEP').val('');
        $('#Rua').val('');
        $('#NumeroEnd').val('');
        $('#Complemento').val('');
        $('#Bairro').val('');
        $('#Cidade').val('');
        $('#UF option[value=""]').attr('selected', 'selected');

        $('#divCPF').hide('slow');
        $('#divCNPJ').hide('slow');
        $('#divNome').hide('fast');
        $('#divNomeEmpresa').hide('slow');
        $('#divEmail').hide('slow');
        $('#divTelefone').hide('slow');
        $('#divCelular').hide('slow');
        $('#divCEP').hide('slow');
        $('#divRua').hide('slow');
        $('#divNumero').hide('slow');
        $('#divComplemento').hide('slow');
        $('#divBairro').hide('slow');
        $('#divCidade').hide('slow');
        $('#divUF').hide('slow');

        return false;
    }
}