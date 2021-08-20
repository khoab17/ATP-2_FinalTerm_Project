app.controller("editproduct",
function($scope,$http,ajax,$routeParams){
    var id = $routeParams.id;

    ajax.get(API_PORT+"/api/Product/"+id,success,error);
    function success(response){
        $scope.product=response.data;

        $scope.editproduct = function (product) {

            ajax.put(API_PORT+"/api/Product/Update",
                product,
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
