app.controller("addproduct",function($scope,$http,ajax){


    ajax.get(API_PORT+"/api/Category/All",success,error);
    function success(response){
        $scope.categories=response.data;
        }
        function error(error){
        }

    $scope.addproduct=function(product)
    {
        ajax.post(API_PORT+"/api/Product/Add",product,function(response){},function(error){});

    }

    
});
