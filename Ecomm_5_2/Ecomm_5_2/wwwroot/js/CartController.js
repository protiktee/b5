var CartController = {
    CartProducts :[],
    AddToCart: (ProductID) => {
        $.get("https://dummyjson.com/products/" + ProductID, function (response) {
            CartController.CartProducts.push(response);
            let ExistsCount = parseInt($('#spnCartCount').html());
            $('#spnCartCount').html(ExistsCount + 1);
            //CartController.ShowCart();
        })
    },
    ShowCart: function () {
        console.log(CartController.CartProducts)
    },
    ShowCartPartial: () => {
        $('#dvCartPartialProduct').html('');
        $.each(CartController.CartProducts, function (index,obj) {

            $('#dvCartPartialProduct').append(`
                <div class="col col-12">
                <div class="card mb-3" style="width:100%">
                    <div class="row g-0">
                        <div class="col-md-4">
                            <img src="${obj.thumbnail}" style="height:100px" class="img-fluid rounded-start" alt="...">
                        </div>
                        <div class="col-md-8">
                            <div class="card-body">
                                <h5 class="card-title">${obj.title}</h5>
                                <p class="card-text"><small class="text-body-secondary">${obj.price}></p>
                            </div>
                        </div>
                    </div>
                </div>
            </div> 
            `);
        })


        $("#dvCartPartial").animate({
            right: "0px"
        }, 500);  
    },
    HideCartPartial: () => {
        console.log($('#dvCartPartial').width())
        $("#dvCartPartial").animate({
            right: "-" + $('#dvCartPartial').width() + "px" 
        }, 500);  
    }
}