app.controller("searchuser",function($scope,$http,ajax,$window,$routeParams){
    var id = $routeParams.id;
    if(!($routeParams.id))
    {
        $window.alert("Enter value to search");
    }
    else{

        ajax.get(API_PORT+"/api/Users/Search/"+id,success,error);
    function success(response){
      $scope.users=response.data;

    }
    function error(error){

    }
    }
    
});
