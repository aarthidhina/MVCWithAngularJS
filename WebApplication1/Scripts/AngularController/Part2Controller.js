angular.module('MyApp') //extending from previously created angular module in the previous part
.controller('Part2Controller', function ($scope, ContactService) { 
    $scope.Contact = null;
    ContactService.GetLastContact().then(function (d) {
        $scope.Contact = d.data; // Success
    }, function () {
        alert('Failed'); // Failed
    });
})
.factory('ContactService', function ($http) { 
    var fac = {};
    fac.GetLastContact = function () {
        return $http.get('/Data/GetLastContact');
    }
    return fac;
});