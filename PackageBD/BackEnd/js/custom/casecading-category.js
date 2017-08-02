////cascading category start
//$(function () {
//    if ($("#CategoryId").val() == '0') {
//        var productDefaultValue = "<option value='0'>--Select a category first--</option>";
//        $("#SubCategoryId").html(productDefaultValue).show();
//    }

//    $("#CategoryId").change(function () {
//        var selectedItemValue = $(this).val();

//        var ddlSubCategories = $("#SubCategoryId");
//        $.ajax({
//            cache: false,
//            type: "GET",
//            url: '@Url.Action("GetSubCategoryByCategoryId", "Products")',
//            data: { "id": selectedItemValue },
//            success: function (data) {
//                ddlSubCategories.html('');
//                $.each(data, function (id, option) {
//                    ddlSubCategories.append($('<option></option>').val(option.id).html(option.name));
//                });
//            },
//            error: function (xhr, ajaxOptions, thrownError) {
//                alert('Found error to load product!!.');
//            }
//        });
//    });
//});