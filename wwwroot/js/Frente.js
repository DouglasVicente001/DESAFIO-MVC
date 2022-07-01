/*Declaração de Variaveis*/
var enderecoProduto = "https://localhost:5001/Produtos/Produto/"
var produto;
var compra = [];
var __totalVenda__ = 0.0;

/*Inicio*/
$("#posvenda").hide(); 
atualizarTotal();
/*Funcções*/

function atualizarTotal(){
    $("#totalVenda").html(__totalVenda__); 
}

function preencherFormulario(dadosProduto){
    $("#campoNome").val(dadosProduto.nome);
    $("#campoCategoria").val(dadosProduto.categoria.nome);
    $("#campoFornecedor").val(dadosProduto.fornecedor.fornecedor); 
    $("#campoPreco").val(dadosProduto.PrecodeVenda);
}

function zerarFormulario(){
    $("#campoNome").val("");
    $("#campoCategoria").val("");
    $("#campoFornecedor").val(""); 
    $("#campoPreco").val(""); 
    $("#campoQuantidade").val("");
}


function adicionarNaTabela(p,q){
    var produtoTemp = {};

    Object.assign(produtoTemp,produto);

    var venda = {produto: produtoTemp,quantidade: q, subtotal: produtoTemp.precoDeVenda * q};       
    __totalVenda__ += venda.subtotal; 
    atualizarTotal();

    compra.push(venda);
    

    $("#compras").append(`<tr>
    <td>${p.id}</td>
    <td>${p.nome}</td>
    <td>${q}</td>
    <td>${p.precoDeVenda} R$: </td>
    <td>${p.medicao}</td>
    <td>${p.precoDeVenda * q} R$: </td>
    <td><button class='btn btn-danger'>Remover</button></td>      
    </td>`);
}


$("#produtoForm").on("submit", function(event){
    event.preventDefault();
    var produtoParaTabela = produto;
    var qtd = $("#campoQuantidade").val();
    console.log(produtoParaTabela);
    console.log(qtd);  

    adicionarNaTabela(produtoParaTabela,qtd);
    // var produto = undefined
    zerarFormulario();
})


/* Ajax */
$("#pesquisar").click(function() {
    var codProduto = $("#codProduto").val();
    var enderecoTemporario = enderecoProduto+codProduto;
    $.post(enderecoTemporario, function(dados,status){
        produto = dados;
        
        var med = "";
        switch(produto.medicao){
            case 0:
                med = "Litros";
                break;
            case 1:
                med = "Kilos";
                break;
            case 2:
                med = "Unidade";
                break;
            default:
                med= "Unidade";
                break;
        }
        produto.medicao = med;

        preencherFormulario(produto); 
    }).fail(function(){
        alert("Produto inválido");
    });
});

$("#finalizarVendaBTN").click(function() {
if(__totalVenda__ <= 0){
    alert("Compra inválida, nenhum produto adicionado!");
    return;
}

var _valorPago = $("#valorPago").val();
console.log(typeof _valorPago);
if(!isNaN(_valorPago)){ //Not a Number / Não é um numero.
    _valorPago = parseFloat(_valorPago); 
    if(_valorPago >= __totalVenda__){
        $("#posvenda").show();
        $("#prevenda").hide();
        $("#valorPago").prop("disabled",true);
        var _troco = _valorPago - __totalVenda__;
        $("#troco").val(_troco);

    }else{
        alert("Valor pago é muito baixo");
        return;
    }

}else{
    alert("Valor pago, inválido");
    return;
}

})

function restaurarModal(){
    $("#posvenda").hide();
    $("#prevenda").show();
    $("#valorPago").prop("disabled",false);
    $("#troco").val("");
    $("#valorPago").val("");
}

$("#fecharModal").click(function (){
    restaurarModal();

})
     

