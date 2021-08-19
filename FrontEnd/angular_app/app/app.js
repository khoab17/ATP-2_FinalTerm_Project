var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/demopage.html"
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
    .when("/edituser", {
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
   
    .when("/products", {
        templateUrl : "views/pages/products.html",
        controller: 'products'
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
