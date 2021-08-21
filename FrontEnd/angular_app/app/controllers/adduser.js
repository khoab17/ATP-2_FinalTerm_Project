app.controller("adduser",function($scope,$http,$location,$window,ajax){

      $scope.adduser=function(user)
      {
          ajax.post("https://localhost:44371/api/Admin/Add",user,function(response){
              $window.alert("User added");
              $location.path("/home")
          },function(error){});

      }

    
});
