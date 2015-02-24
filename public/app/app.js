$(runApp);

function runApp() {

    getLocation(locationCallback);
    testMap();
}

function locationCallback(location) {
    $('#coords').html(location.coords.latitude + ' latitude, ' + location.coords.longitude + ' longitude.');
}

function locationFailedCallback() {
    $('#coords').html("Geolocation is not supported by this browser.");
}

function getLocation(callBack) {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(callBack);
    } else {
        locationFailedCallback();
    }
}

function testMap() {
    var mapProp = {
        center: new google.maps.LatLng(-41.295233, 174.773124),
        zoom: 16,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById("google-map"), mapProp);
}