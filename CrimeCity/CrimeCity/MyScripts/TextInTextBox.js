$(document).ready(function () {
    $("#SearchCriteria_FirstName").val("First name")
    $("#SearchCriteria_FirstName").focus(function () {
        if (this.value == "First name")
        {
            this.value = "";
            $("#SearchCriteria_FirstName").removeClass("greyColor");
        }
    });
});

$(document).ready(function () {
    $("#SearchCriteria_LastName").val("Last name")
    $("#SearchCriteria_LastName").focus(function () {
        if (this.value == "Last name")
        {
            this.value = "";
            $("#SearchCriteria_LastName").removeClass("greyColor");
        }
    });
});
