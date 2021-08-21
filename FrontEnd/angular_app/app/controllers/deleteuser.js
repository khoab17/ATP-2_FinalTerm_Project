app.controller("deleteuser",
function($scope,$http,ajax,$location,$window,$routeParams){
    var id = $routeParams.id;
    //var message;
   // message.succ="";
    ajax.get(API_PORT+"/api/User/"+id,success,error);
    function success(response){
        $scope.user=response.data;

        }
        function error(error){
    
    }

    $scope.deleteuser = function (user) {
       // if(confirm('Are you sure your want to delete?')) {
          ajax.delete(
            API_PORT + "/api/User/delete/"+ user.Id,
            user,
            function (response) {
              // console.log(response);
              $location.path("/home");
            },
            function (err) {
              console.log(err);
            }
          );
       // }
  
      };

    

});
