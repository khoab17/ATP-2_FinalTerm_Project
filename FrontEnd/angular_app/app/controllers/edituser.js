app.controller("edituser",
function($scope,$http,ajax,$routeParams){
    var id = $routeParams.id;

    ajax.get("https://localhost:44371/api/User/"+id,success,error);
    function success(response){
        $scope.user=response.data;

        $scope.editUser = function (user) {

            ajax.put("https://localhost:44371/api/User/Update",
                user,
                function (response) {
                  // console.log(response);
                },
                function (err) {
                  console.log(err);}
            );
    
        };
        }
        function error(error){
    
    }

    

});
