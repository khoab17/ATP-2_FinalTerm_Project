app.controller("orders",function($scope,$http,ajax){
    ajax.get(API_PORT+"/api/Order/All",success,error);
    function success(response){
      $scope.orders=response.data;
    }
    function error(error){
    }
    
});