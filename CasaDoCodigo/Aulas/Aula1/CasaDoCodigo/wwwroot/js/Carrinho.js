class Carrinho {

    clickIncremento(btn) {

        let data = this.GetData(btn);
        data.Quantidade++;
        this.PostQtde(data);
        
    }

    clickDecremento(btn) {

        let data = this.GetData(btn);
        data.Quantidade--;
        this.PostQtde(data);

    }

    GetData(elemento) {
        var linhaDoItem = $(elemento).parents('[item-id]');
        var itemId = $(linhaDoItem).attr('item-id');
        var novaQtde = $(linhaDoItem).find('input').val();

        return {
            Id: itemId,
            Quantidade: novaQtde
        };
    }

    PostQtde(data) {

        let token = $('[name=__RequestVerificationToken]').val();

        let headers = {};
        headers['RequestVerificationToken'] = token; 

        $.ajax({
            url: '/pedido/UpdateQuantidade',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data),
            headers: headers
        }).done(function (response) {
            let itemPedido = response.itemPedido;
            let linhaDoItem = $('[item-id=' + itemPedido.id + ']')
            linhaDoItem.find('input').val(itemPedido.quantidade);
            linhaDoItem.find('[subtotal]').html((itemPedido.subtotal).duasCasas());
            let carrinhoViewModel = response.carrinho;
            $('[numero-itens]').html('Total:' + carrinhoViewModel.itens.length + ' itens');
            $('[total]').html((carrinhoViewModel.total).duasCasas());

            if (itemPedido.quantidade == 0) {
                linhaDoItem.remove();
            }
        });
        
    }

    UpdateQtde(input) {
        let data = this.GetData(input);
        this.PostQtde(data);
    }
}
var carrinho = new Carrinho();


Number.prototype.duasCasas = function () {
    return this.toFixed(2).replace('.', ',');
}