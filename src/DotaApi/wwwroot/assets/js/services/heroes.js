(function () {
    'use strict';

    angular
        .module('app')
        .factory('heroes', heroes);

    heroes.$inject = ['$http'];

    function heroes($http) {
        var service = {
            get: get
        };

        return service;

        function get() {
            return $http.get('/api');
        }
    }
})();