app.controller("category",function($scope,$http,ajax){

    $scope.category=function(category)
    {
            ajax.post(API_PORT+"/api/Category/Add",category,function(response){},function(error){});

    }

  
});
