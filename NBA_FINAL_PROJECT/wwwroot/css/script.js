function initialize(coordenadas, nombre, estadio, inicio) {
    mapboxgl.accessToken = 'pk.eyJ1IjoiYWdhcmNpYWVsbyIsImEiOiJjbGgwYXBkZ2UwcnI4M3BxY2V1cThlZGVtIn0.zpbXw-zZVNEZcG3aAJTA3Q';
    const map = new mapboxgl.Map({
        container: 'map', // container ID
        // Choose from Mapbox's core styles, or make your own style with Mapbox Studio
        style: 'mapbox://styles/agarciaelo/clh0b0fh400j001quaz1j511x', // style URL
        center: [inicio[1], inicio[0]], // starting position [lng, lat]
        zoom: 4.5, // starting zoom
    });

    map.addControl(
        new MapboxDirections({
            accessToken: mapboxgl.accessToken,
            language: 'es',
            interactive: false
        }),
        'top-left'
    );

    map.addControl(new mapboxgl.NavigationControl());

    for (var i = 0; i < (coordenadas.length / 2); i++) {

        var num1 = i * 2;
        var num2 = i * 2 + 1;
        
        let lat = coordenadas[num1];
        let lng = coordenadas[num2];

        var element = document.createElement('div');
        element.className = nombre[i];

        var popup = new mapboxgl.Popup().setText(estadio[i]);

        var marcador = new mapboxgl.Marker(element).setLngLat({ lng, lat }).setPopup(popup).addTo(map);

        popup.on('open', () => { map.setCenter([lng, lat]).setPitch(60).zoomTo(17, { duration: 3000 }) });
        popup.on('close', () => { map.setPitch(0) });
    }
}

function dialog(open) {

    var element = document.getElementById('ms');
    if (element != null) {
        if (open) {
            element.showModal();
        } else {
            element.close();
        }
    }
}

function lockBody(lock) {
    if (lock) {
        document.body.classList.add('locked');
    } else {
        document.body.classList.remove('locked');
    }
}
