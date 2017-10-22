$(document).ready(function () {
    $(".open_account_btn").click(function () {
        $(".open_account_panel").show(200);
    });
    $(".close_account_panel").click(function () {
        $(".open_account_panel").hide(200);
    });
    $("#login_panel").click(function () {
        $(".login-panel").slideDown();
    });
    $(".close_login_panel").click(function () {
        $(".login-panel").slideUp();
    });
});