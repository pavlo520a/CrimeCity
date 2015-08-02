$("#NewEmployeeBtn").click(function () {
    $("#NewEmployee").removeClass("displayNone");
    $("#Employees").addClass("displayNone");
    $("#PolisePosition").addClass("displayNone");
    $("#NewEmployeeBtn").addClass("activeBtn");
    $("#EmployeesBtn").removeClass("activeBtn");
    $("#PolicePositionBtn").removeClass("activeBtn");
});

$("#EmployeesBtn").click(function () {
    $("#Employees").removeClass("displayNone");
    $("#NewEmployee").addClass("displayNone");
    $("#PolisePosition").addClass("displayNone");
    $("#EmployeesBtn").addClass("activeBtn");
    $("#NewEmployeeBtn").removeClass("activeBtn");
    $("#PolicePositionBtn").removeClass("activeBtn");
});

$("#PolicePositionBtn").click(function () {
    $("#PolisePosition").removeClass("displayNone");
    $("#NewEmployee").addClass("displayNone");
    $("#Employees").addClass("displayNone");
    $("#PolicePositionBtn").addClass("activeBtn");
    $("#NewEmployeeBtn").removeClass("activeBtn");
    $("#EmployeesBtn").removeClass("activeBtn");
});