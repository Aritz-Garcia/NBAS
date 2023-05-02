function initialize(coordenadas, nombre, estadio, inicio) {
    mapboxgl.accessToken = 'pk.eyJ1IjoiYWdhcmNpYWVsbyIsImEiOiJjbGgwYXBkZ2UwcnI4M3BxY2V1cThlZGVtIn0.zpbXw-zZVNEZcG3aAJTA3Q';
    const map = new mapboxgl.Map({
        container: 'map', // container ID
        // Choose from Mapbox's core styles, or make your own style with Mapbox Studio
        style: 'mapbox://styles/mapbox/streets-v12', // style URL
        center: [inicio[1], inicio[0]], // starting position [lng, lat]
        zoom: 4.5 // starting zoom
    });

    for (var i = 0; i < (coordenadas.length / 2); i++) {

        var num1 = i * 2;
        var num2 = i * 2 + 1;
        
        let lat = coordenadas[num1];
        let lng = coordenadas[num2];

        var element = document.createElement('div');
        element.className = nombre[i];

        var popup = new mapboxgl.Popup().setText(estadio[i]);

        var marcador = new mapboxgl.Marker(element).setLngLat({ lng, lat }).setPopup(popup).addTo(map);

        popup.on('open', () => { map.setCenter([lng, lat]).zoomTo(17, { duration: 3000 }) });
    }
}