(function () {
    //Create a Module 
    var app = angular.module('MyApp', ['ngRoute']);  

    //Create a Controller
    app.controller('HomeController', function ($scope) {  
        $scope.Message = "Yahoooo! we have successfully done our first part.";
    });
})();