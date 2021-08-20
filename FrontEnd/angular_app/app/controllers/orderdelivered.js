app.controller("orderdelivered",function($scope,$http,ajax){
    ajax.get(API_PORT+"/api/Order/Delivered",success,error);
    function success(response){
      $scope.orders=response.data;
    }
    function error(error){
    }
    
});