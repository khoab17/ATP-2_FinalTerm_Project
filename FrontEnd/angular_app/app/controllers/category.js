app.controller("category",function($scope,$http,$window,ajax){

    $scope.category=function(category)
    {
            ajax.post(API_PORT+"/api/Category/Add",category,function(response){
                $window.alert("Category Added");
            },function(error){});

    }

  
});
