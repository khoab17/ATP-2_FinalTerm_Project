app.controller("edituser",function($scope,$http,ajax){

    $scope.edituser=function(id)
    {
        ajax.post("https://localhost:44371/api/user/"+id,user,function(response){},function(error){});
        function success(response){
            $scope.user=response.data;
          }
          function error(error){
      
          }
    }
});
