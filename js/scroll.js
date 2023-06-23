window.addEventListener('scroll', () => {
	const num = window.pageYOffset / (document.body.offsetHeight - window.innerHeight);

	const visual = document.querySelector('.intro_visual__img');
	const bottom = document.querySelector('.intro_bottom');
	let scrollLocation = document.documentElement.scrollTop;

	const scroll = window.scrollY;
	let top = visual.offsetTop - 100;
	let scroll2 = scroll - visual.offsetTop;
	const compStyles = window.getComputedStyle(visual);
	// console.log(parseInt(compStyles.getPropertyValue('height')));
	const number = parseInt(compStyles.getPropertyValue('padding-top'));
	const number2 = (number * scroll2) / (top - bottom.offsetTop);
	const number3 = number - number2;

	if (scrollLocation >= top && bottom.offsetTop > scrollLocation) {
		visual.classList.add('now');
		console.log(number2, 'number2');
		console.log(number3, 'number3');
		// visual.style.paddingTop = number / numbe + 'px';
	} else {
		visual.classList.remove('now');
		// visual.style.paddingTop = number + '%';
	}
});
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
const baseline = -300;
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
			for (const el of btns) el.classList.remove('on');
			btns[idx].classList.add('on');
			//for (const el of secs) el.classList.remove('on');
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
