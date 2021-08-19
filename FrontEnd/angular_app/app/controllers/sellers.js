app.controller("sellers",function($scope,$http,ajax){
    ajax.get("https://localhost:44371/api/Seller/GetAll",success,error);
    function success(response){
      $scope.sellers=response.data;
    }
    function error(error){
    }
    
});
