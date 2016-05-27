(function () {
    'use strict';

    angular.module('app', [
            // Angular modules 
            "ngRoute"

            // Custom modules 

            // 3rd Party Modules
        ])
        .config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
            $routeProvider.when("/test", {
                templateUrl: "/templates/Heroes.html",
                controller: "homeController",
                controllerAs: "ctrl"
            });

            $locationProvider.html5Mode(true);
        }]);
})();