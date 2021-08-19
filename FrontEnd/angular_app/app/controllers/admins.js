app.controller("admins",function($scope,$http,ajax){
    ajax.get("https://localhost:44371/api/Admin/GetAll",success,error);
    function success(response){
      $scope.admins=response.data;
    }
    function error(error){
    }
    
});
