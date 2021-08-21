app.controller("editproduct",
function($scope,$http,ajax,$location,$window,$routeParams){
    var id = $routeParams.id;



    ajax.get(API_PORT+"/api/Product/"+id,success,error);
    function success(response){
        $scope.product=response.data;

        ajax.get(API_PORT+"/api/Category/All",success,error);
        function success(response){
            $scope.categories=response.data;
            function error(error){
            }
            }

        $scope.editproduct = function (product) {

            ajax.put(API_PORT+"/api/Product/Update",
                product,
                function (response) {
                  // console.log(response);
                  $window.alert("Updated");
                  $location.path("/products");
                },
                function (err) {
                  console.log(err);}
            );
    
        };
        }
        function error(error){
    
    }

    

});
