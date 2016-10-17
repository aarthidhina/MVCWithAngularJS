angular.module('MyApp') 
           .controller('Part4Controller', function ($scope, EmployeeService) { 
               $scope.Employees = null;
               EmployeeService.GetEmployeeList().then(function (d) {
                   $scope.Employees = d.data; //Success callback
               }, function (error) {
                   alert('Error!'); // Failed Callback
               });
           })
           .factory('EmployeeService', function ($http) { 

               var fac = {};
               fac.GetEmployeeList = function () {
                   return $http.get('/Data/GetEmployeeList')
               }
               return fac;
           });
