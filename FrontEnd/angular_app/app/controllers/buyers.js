app.controller("buyers",function($scope,$http,ajax){
    ajax.get("https://localhost:44371/api/Buyer/GetAll",success,error);
    function success(response){
      $scope.buyers=response.data;
    }
    function error(error){
    }   
});
