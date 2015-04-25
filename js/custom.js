$(document).ready(function () {
    function hasPosition() {
        var point = new google.maps.LatLng(21.152344, -101.711127),

            myOptions = {
                zoom: 15,
                center: point,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            },

            mapDiv = document.getElementById("maps-container"),
            map = new google.maps.Map(mapDiv, myOptions),

            marker = new google.maps.Marker({
                position: point,
                map: map,
                title: "Universidad De La Salle Bajío"
            });
    }

    navigator.geolocation.getCurrentPosition(hasPosition);

});