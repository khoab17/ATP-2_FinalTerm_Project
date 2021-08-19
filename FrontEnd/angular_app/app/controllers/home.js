app.controller("home",function($scope,$http,ajax){
    ajax.get("https://localhost:44371/api/Users/All",success,error);
    function success(response){
      $scope.users=response.data;
    }
    function error(error){

    }
});


