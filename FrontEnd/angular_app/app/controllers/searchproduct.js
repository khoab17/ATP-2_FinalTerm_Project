app.controller("searchproduct",function($scope,$http,ajax,$window,$routeParams){
    var id = $routeParams.id;
    if(!($routeParams.id))
    {
        $window.alert("Enter value to search");
    }
    else{

        ajax.get(API_PORT+"/api/Product/Search/"+id,success,error);
    function success(response){
      $scope.products=response.data;

    }
    function error(error){

    }
    }
    
});
