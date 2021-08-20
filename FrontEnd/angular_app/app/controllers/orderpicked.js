app.controller("orderpicked",function($scope,$http,ajax){
    ajax.get(API_PORT+"/api/Order/Picked",success,error);
    function success(response){
      $scope.orders=response.data;
    }
    function error(error){
    }
    
});