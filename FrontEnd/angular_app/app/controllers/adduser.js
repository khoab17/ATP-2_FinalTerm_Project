app.controller("adduser",function($scope,$http,ajax){

      $scope.adduser=function(user)
      {
          ajax.post("https://localhost:44371/api/Admin/Add",user,function(response){},function(error){});

      }

    
});
