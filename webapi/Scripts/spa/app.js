(function () { 
    "use strict";

    angular.module("crmApp", ["ui.router"])


    .controller("LoginController", function () {

    })

    .config(function ($stateProvider, $urlRouterProvider) {
        $stateProvider
            .state("customer", {
                url: "/customer",
                templateUrl : "Scripts/spa/views/customer.html"
            })

        $stateProvider
            .state("home", {
                url: "/home",
                templateUrl : "Scripts/spa/views/home.html"
            })

        $stateProvider
            .state("product", {
                url: "/product",
                templateUrl:"Scripts/spa/views/product.html"
            })

        $urlRouterProvider.otherwise("/home");
    })

})();