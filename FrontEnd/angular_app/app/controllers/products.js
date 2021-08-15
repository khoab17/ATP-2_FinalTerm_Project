app.controller("products",function($scope,$http,ajax){
    ajax.get("https://localhost:44371/api/Product/All",success,error);
    function success(response){
      $scope.products=response.data;
    }
    function error(error){

    }

});
