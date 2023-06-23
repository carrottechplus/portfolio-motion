const timeElements = document.querySelectorAll('.clock_text .clock_realtime');
const [am, pm] = document.querySelectorAll('.clock_text .clock_dl');

// 1. 현재 시간 가져오기
// 2. 화면에 시간 찍기
// 3. 실시간 업데이트
// 4. 12시간
// 5. 1의자리 숫자일때 앞에 0붙이기

function getTime() {
	const now = new Date();
	let hr = now.getHours();
	let min = now.getMinutes();
	let sec = now.getSeconds();

	if (hr > 12) {
		hr = hr - 12;
		am.classList.remove('on');
		pm.classList.add('on');
	} else {
		am.classList.add('on');
		pm.classList.remove('on');
	}

	return [hr, min, sec];
}

function setTime(num, index) {
	if (num < 10) num = '0' + num;
	else num = num;

	timeElements[index].innerText = num;
}

// setTime(12, 0);
// setTime(13, 1);

setInterval(() => {
	getTime().forEach((time, index) => {
		setTime(time, index);
	});
}, 1000);

const header = document.querySelector('.header_wrap');
let lastScroll = document.documentElement.scrollTop || 0;
header.classList.contains('scrollUp').remove;

document.addEventListener('scroll', () => {
	let scrollTop = document.documentElement.scrollTop;
	if (scrollTop > lastScroll) {
		// down
		header.classList.add('scrollDown');
	} else {
		//up
		header.classList.remove('scrollDown');
		// header.classList.add('scrollUp');
	}
	lastScroll = scrollTop;
});

const totop = document.querySelector('.btn_totop');
totop.addEventListener('click', () => {
	window.scrollTo({ top: 0, behavior: 'smooth' });
});
