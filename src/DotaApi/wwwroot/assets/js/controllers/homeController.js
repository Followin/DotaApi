(function () {
    'use strict';

    angular
        .module('app')
        .controller('HomeController', HomeController);

    HomeController.$inject = ['heroes']; 

    function HomeController(heroes) {
        var self = this;
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'HomeController';

        activate();

        function activate() {
            heroes.get().then(function (data) {
                console.log(data.data);
                self.heroes = data.data;
            });
        }
    }
})();
