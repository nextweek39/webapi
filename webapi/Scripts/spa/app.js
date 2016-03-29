(function () { 
   

    angular.module("crmApp", ["ui.router"])


    .controller("productController", function ($scope) {
  
        $scope.showModal = false;
        $scope.toggleModal = function () {
            $scope.showModal = !$scope.showModal;
        };

    })

    .directive("modal", function () {
        return {
            template: '<div class="modal fade">' +
                '<div class="modal-dialog">' +
                  '<div class="modal-content">' +
                    '<div class="modal-header">' +
                      '<button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>' +
                      '<h4 class="modal-title">{{ title }}</h4>' +
                    '</div>' +
                    '<div class="modal-body" ng-transclude></div>' +
                  '</div>' +
                '</div>' +
              '</div>',
            restrict: 'E',
            transclude: true,
            replace: true,
            scope: true,
            link: function postLink(scope, element, attrs) {
                scope.title = attrs.title;

                scope.$watch(attrs.visible, function (value) {
                    if (value == true)
                        $(element).modal('show');
                    else
                        $(element).modal('hide');
                });

                $(element).on('shown.bs.modal', function () {
                    scope.$apply(function () {
                        scope.$parent[attrs.visible] = true;
                    });
                });

                $(element).on('hidden.bs.modal', function () {
                    scope.$apply(function () {
                        scope.$parent[attrs.visible] = false;
                    });
                });
            }
        };
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