var crmApp = angular.module("crmApp", ["ui.router"]);


crmApp.controller("LoginController", function () {

})

crmApp.config(function ($stateProvider, $urlRouterProvider) {
    $stateProvider
        .state("login", {
            url: "/login",
            templateUrl : "Scripts/spa/views/login.html"
        });

    $stateProvider
        .state("home", {
            url: "/home",
            templateUrl : "Scripts/spa/views/home.html"
        })

    $urlRouterProvider.otherwise("/login");
})