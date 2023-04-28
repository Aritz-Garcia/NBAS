function initialize(coordenadas, nombre) {
    mapboxgl.accessToken = 'pk.eyJ1IjoiYWdhcmNpYWVsbyIsImEiOiJjbGgwYXBkZ2UwcnI4M3BxY2V1cThlZGVtIn0.zpbXw-zZVNEZcG3aAJTA3Q';
    const map = new mapboxgl.Map({
        container: 'map', // container ID
        // Choose from Mapbox's core styles, or make your own style with Mapbox Studio
        style: 'mapbox://styles/mapbox/streets-v11', // style URL
        center: [-101.46394314630489, 39.97724130613545], // starting position [lng, lat]
        zoom: 5 // starting zoom
    });

    for (var i = 0; i < nombre.length; i++) {

        var num1 = i * 2;
        var num2 = i * 2 + 1;
        
        let lng = coordenadas[num1];
        let lat = coordenadas[num2];

        var element = document.createElement('div');
        element.className = nombre[i];

        var marcador = new mapboxgl.Marker(element).setLngLat({ lng, lat }).addTo(map);
    }
}