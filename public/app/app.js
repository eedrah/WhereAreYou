$(runApp);

function runApp() {

    getLocation(locationCallback);
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