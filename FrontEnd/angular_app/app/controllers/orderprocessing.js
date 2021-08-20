app.controller("orderprocessing",function($scope,$http,ajax){
    ajax.get(API_PORT+"/api/Order/Processing",success,error);
    function success(response){
      $scope.orders=response.data;
    }
    function error(error){
    }
    
});