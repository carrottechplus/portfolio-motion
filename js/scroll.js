// window.addEventListener('scroll', () => {
//   let scrollLocation = document.documentElement.scrollTop; // 현재 스크롤바 위치
//   let windowHeight = window.innerHeight; // 스크린 창
//   let fullHeight = document.body.scrollHeight; //  margin 값은 포함 x

//   if (scrollLocation + windowHeight >= fullHeight) {
//     console.log('끝')
//   }
// })
const secs = document.querySelectorAll('.myScroll');
const list = document.querySelector('#scroll_navi');
const btns = list.querySelectorAll('button');
const speed = 500;
const baseline = -window.innerHeight / 2;
// const baseline = 300;
console.log(baseline);
let enableEvent = true;
let autoScroll = false;
let eventBlocker = null;

window.addEventListener('scroll', () => {
	if (eventBlocker) return;
	eventBlocker = setTimeout(() => {
		activation();
		eventBlocker = null;
	}, speed);
});
window.addEventListener('resize', () => {
	if (eventBlocker) return;
	eventBlocker = setTimeout(() => {
		modifyPos();
		eventBlocker = null;
	}, speed);
});
autoScroll && window.addEventListener('mousewheel', moveAuto, { passive: false });

btns.forEach((btn, idx) => {
	btn.addEventListener('click', () => enableEvent && moveScroll(idx));
});

function activation() {
	const scroll = window.scrollY;

	if (scroll <= 500) {
		for (const el of secs) el.classList.remove('on');
	}

	secs.forEach((_, idx) => {
		if (scroll >= secs[idx].offsetTop + baseline) {
			console.log(scroll, '1');
			console.log(secs[idx].offsetTop, '2');
			console.log(secs[idx].offsetTop + baseline, '3');
			for (const el of btns) el.classList.remove('on');
			btns[idx].classList.add('on');
			secs[idx].classList.add('on');
		}
	});
}

function moveScroll(idx) {
	enableEvent = false;
	new Anime(window, {
		prop: 'scroll',
		value: secs[idx].offsetTop,
		duration: speed,
		callback: () => (enableEvent = true),
	});
}

function modifyPos() {
	const active = list.querySelector('li.on');
	const active_index = Array.from(btns).indexOf(active);
	console.log(active_index);
	window.scrollTo({ top: secs[active_index].offsetTop, behavior: 'smooth' });
}

function moveAuto(e) {
	e.preventDefault();
	const active = list.querySelector('li.on');
	const active_index = Array.from(btns).indexOf(active);

	if (e.deltaY > 0) {
		if (active_index === btns.length - 1) return;
		moveScroll(active_index + 1);
	} else {
		if (active_index === 0) return;
		moveScroll(active_index - 1);
	}
}
