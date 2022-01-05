var ManageProduct = function () {
    var init = function () {
        //BindEvent();
        GetDataProduct();
    };
   
    var GetDataProduct = function () {
        $('#example').DataTable({
            "destroy": true,
            "ajax": "/Products/GetProduct",
            
            "columns": [
                {
                    "data": "ProductID"

                },
            
                { "data": "Name" },
                { "data": "Description" },

            ]
        });
    };
    return {
        Init: init
    }
}();

function editproduct(thiss) {
    var ProductId = $(thiss).parent('td').find('#ProductId').val();
    $.ajax({
        url: "/Product/EditDetails?ProductId=" + ProductId,
        type: "POST",
        dataType: "JSON",
        success: function (EditData) {
            GetproductData(EditData);
        },
        error: function (errordata) {
            console.log(errordata);
        }
    });
    var GetproductData = function (EditData) {
        $('#ProductId').val(EditData.ProductId);
        $('#txtProdName').val(EditData.Name);
        $('#txtDes').val(EditData.Description);
    }
}