$(document).ready(function (e) {
    var link = $("input[name='urlAdicionarCarrinho']").val();
    $(".linkComprar").click(function () {
        var idProduto = $(this).attr("id");
        $.ajax({
            type: "POST",
            url: link,
            data: { idProduto: idProduto },
            sucess: function (result) {

            },
            error:
                function () {
                    alert("Erro na requisição Ajax");
                }
        });

        alert("Item adicionado ao carrinho");
    });

    $("#comprarProdutos").click(function () {
        var listaCheckbox = $(".checkboxCategoria:checked");

        $.each(listaCheckbox, function (index, element) {
            $.ajax({
                type: "POST",
                url: link,
                data: { idProduto: $(element).val() },
                sucess: function (result) {

                },
                error:
                    function () {
                        alert("Erro na requisição Ajax");
                    }
            });
        });

        alert("Item adicionado ao carrinho");
    });
});