app.controller("deleteproduct",
function($scope,$http,ajax,$location,$window,$routeParams){
    var id = $routeParams.id;
    //var message;
   // message.succ="";
    ajax.get(API_PORT+"/api/Product/"+id,success,error);
    function success(response){
        $scope.product=response.data;

        }
        function error(error){
    
    }

    $scope.deleteproduct = function (product) {
       // if(confirm('Are you sure your want to delete?')) {
          ajax.delete(
            API_PORT + "/api/Product/Delete/"+ product.Id,
            product,
            function (response) {
              // console.log(response);
              $window.alert("Product removed.");
              $location.path("/products");
            },
            function (err) {
              console.log(err);
            }
          );
       // }
  
      };
    });
