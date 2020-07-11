(function () {
    "use strict";
    angular
        .module("mainApp")
        .controller("addController", AddController);

    // Inject services
    AddController.$inject = ["$scope", "$window", "service"];

    function AddController($scope, $window, service) {
        var vm = this;

        // View model
        vm.item = {};
        vm.items = [];
        vm.$scope = $scope;
        vm.service = service;
        vm.$onInit = _init;
        vm.add = _add;
        vm.load = _load;

        // The Fold
        // Initialize
        function _init() {
            console.log("Initialized.");
            //vm.service.get('/api/character/')
            //    .then(_getSuccess, _error);
        }

        // Add Button
        function _add() {
            console.log("Add button clicked.");
            vm.item.tier2 = 0;
            console.log(vm.item);
        }

        // Load Button
        function _load() {
            console.log("Load button clicked.");
            vm.item = {
                "atkSpeed": 100,
                "critRate": 1,
                "critDmg": 115,
                "ignoreDef": 0,
                "ignoreDodge": 0,
                "fireDmg": 0,
                "coldDmg": 0,
                "lightningDmg": 0,
                "poisonDmg": 0,
                "mindDmg": 0,
                "recoveryRate": 100,
                "dodge": 1,
                "moveSpd": 100,
                "debuff": 0,
                "skillCooldown": 0,
                "fireResist": 0,
                "coldResist": 0,
                "lightningResist": 0,
                "poisonResist": 0,
                "mindResist": 0
            }
        }

        // Get By Id Success
        //function _getSuccess(res) {
        //    console.log(res);
        //    vm.items = res.data.items;
        //    console.log(vm.items);
        //}

        // Error
        function _error(err) {
            console.log(err);
        }
    }
})();