// const footer = document.querySelector('footer');
const timeElements = document.querySelectorAll('.clock_text .clock_realtime');
const [am, pm] = document.querySelectorAll('.clock_text .clock_dl');
console.log(am);

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
console.log(getTime());

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
