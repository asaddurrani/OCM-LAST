// Setup requirejs
(function () {

    var root = this;

    requirejs.config({
        baseUrl: "/Scripts/App",
        waitSeconds: 20,
        paths: {
            "product": "/Areas/Product/Scripts",
            "common": "/Areas/Common/Scripts",
            "store": "/Areas/Store/Scripts",
            "vehicle": "/Areas/Vehicle/Scripts",
            "oil": "/Areas/Oil/Scripts",
            "record": "/Areas/Record/Scripts",
            "airFilter": "/Areas/AirFilter/Scripts",
            "brakeOil": "/Areas/BrakeOil/Scripts",
            "bodyPolish": "/Areas/BodyPolish/Scripts",
            "bodyWax": "/Areas/BodyWax/Scripts",
            "autoTransFluid": "/Areas/AutoTransFluid/Scripts",
            "oilFilter": "/Areas/OilFilter/Scripts",
            "powerSteeringOil": "/Areas/PowerSteeringOil/Scripts",
            "carShampoo": "/Areas/CarShampoo/Scripts",
            "coolent": "/Areas/Coolent/Scripts",
            "engineSpray": "/Areas/EngineSpray/Scripts",
            "fuelFilter": "/Areas/FuelFilter/Scripts",
            "internalSpray": "/Areas/InternalSpray/Scripts",
            "manualTransFluid": "/Areas/ManualTransFluid/Scripts",
            "microFibre": "/Areas/MicroFibre/Scripts",
            "petrolAdditive": "/Areas/PetrolAdditive/Scripts",
            "seatFoamSpray": "/Areas/SeatFoamSpray/Scripts",
            "tyreWax": "/Areas/TyreWax/Scripts",
        }

    });

    function defineThirdPartyModules() {
        // These are already loaded via bundles. 
        // We define them and put them in the root object.
        define("jquery", [], function () { return root.jQuery; });
        define("ko", [], function () { return root.ko; });
        define("underscore-knockout", [], function () { });
        define("underscore-ko", [], function () { });
        define("knockout", [], function () { return root.ko; });
        define("knockout-validation", [], function () { });
        define("moment", [], function () { return root.moment; });
        define("amplify", [], function () { return root.amplify; });
        define("underscore", [], function () { return root._; });
    }

    defineThirdPartyModules();


})();
