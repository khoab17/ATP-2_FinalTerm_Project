var app = angular.module("myApp", ["ngRoute"]);
var API_PORT = "https://localhost:44371";
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/home.html"
    })
    .when("/home", {
        templateUrl : "views/pages/home.html",
          controller: 'home'
    })
    .when("/admins", {
        templateUrl : "views/pages/admins.html",
          controller: 'admins'
    })
    .when("/buyers", {
        templateUrl : "views/pages/buyers.html",
          controller: 'buyers'
    })
    .when("/adduser", {
        templateUrl : "views/pages/adduser.html",
          controller: 'adduser'
    })
    .when("/edituser/:id", {
        templateUrl : "views/pages/edituser.html",
          controller: 'edituser'
    })

    .when("/sellers", {
        templateUrl : "views/pages/sellers.html",
          controller: 'sellers'
    })

    .when("/products", {
        templateUrl : "views/pages/products.html",
        controller: 'products'
    })

    .when("/addproduct", {
      templateUrl : "views/pages/addproduct.html",
      controller: 'addproduct'
  })

  .when("/product/edit/:id", {
    templateUrl : "views/pages/editproduct.html",
    controller: 'editproduct'
  })

    .when("/orders", {
      templateUrl : "views/pages/orders.html",
      controller: 'orders'
  })
    .when("/order/processing", {
      templateUrl : "views/pages/orderprocessing.html",
      controller: 'orderprocessing'
  })
  .when("/order/picked", {
    templateUrl : "views/pages/orderpicked.html",
    controller: 'orderpicked'
  })
  .when("/order/delivered", {
    templateUrl : "views/pages/orderdelivered.html",
    controller: 'orderdelivered'
  })

  .when("/category", {
    templateUrl : "views/pages/category.html",
    controller: 'category'
})

    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
