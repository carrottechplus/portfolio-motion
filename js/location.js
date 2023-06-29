const mapContainer = document.querySelector('#map');
const btns = document.querySelectorAll('.branch button');
const btnToggle = document.querySelector('.btnToggle');
let active_index = 0;
let toggle = true;

const markerInfo = [
	{
		title: '광화문',
		position: new kakao.maps.LatLng(37.57598923870742, 126.9768610125929),
		imgSrc: 'img/marker.png',
		imgSize: new kakao.maps.Size(85, 85),
		imgPos: { offset: new kakao.maps.Point(85, 85) },
		button: btns[0],
	},
	{
		title: '수정전',
		position: new kakao.maps.LatLng(37.578987, 126.976045),
		imgSrc: 'img/marker.png',
		imgSize: new kakao.maps.Size(85, 85),
		imgPos: { offset: new kakao.maps.Point(85, 85) },
		button: btns[1],
	},
	{
		title: '카카오본사',
		position: new kakao.maps.LatLng(33.450701, 126.570667),
		imgSrc: 'img/marker.png',
		imgSize: new kakao.maps.Size(85, 85),
		imgPos: { offset: new kakao.maps.Point(85, 85) },
		button: btns[2],
	},
];

const map = new kakao.maps.Map(mapContainer, { center: markerInfo[0].position, level: 3 });

map.setZoomable(false);

const mapTypeControl = new kakao.maps.MapTypeControl();
map.addControl(mapTypeControl, kakao.maps.ControlPosition.TOPRIGHT);
const zoomControl = new kakao.maps.ZoomControl();
map.addControl(zoomControl, kakao.maps.ControlPosition.BOTTOMRIGHT);

map.addOverlayMapTypeId(kakao.maps.MapTypeId.TRAFFIC);

btnToggle.addEventListener('click', () => {
	toggle = !toggle;
	if (toggle) {
		map.addOverlayMapTypeId(kakao.maps.MapTypeId.TRAFFIC);
		btnToggle.innerHTML = '교통 상황 보지 않기';
	} else {
		map.removeOverlayMapTypeId(kakao.maps.MapTypeId.TRAFFIC);
		btnToggle.innerHTML = '교통 상황 보기';
	}
});

markerInfo.forEach((info, idx) => {
	const marker = new kakao.maps.Marker({
		position: info.position,
		image: new kakao.maps.MarkerImage(info.imgSrc, info.imgSize, info.imgPos),
	});

	marker.setMap(map);
	info.button.addEventListener('click', () => {
		active_index = idx;
		map.panTo(info.position);

		for (const el of btns) el.classList.remove('on');
		btns[idx].classList.add('on');
	});
});

window.addEventListener('resize', () => {
	map.setCenter(markerInfo[active_index].position);
});
