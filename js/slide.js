const btnPlay = document.querySelector('.btnPlay');
const btnPause = document.querySelector('.btnPause');
const pagination = document.querySelector('.swiper-pagination');
const btnPrev = document.querySelector('.swiper-button-prev');
const btnNext = document.querySelector('.swiper-button-next');

const swiper = new Swiper('#visual', {
	loop: true,
	//effect: 'fade',

	navigation: {
		nextEl: '.swiper-button-next',
		prevEl: '.swiper-button-prev',
	},
	autoplay: {
		delay: 2000,
	},
});

btnPlay.addEventListener('click', () => {
	swiper.autoplay.start();
	btnPlay.classList.add('on');
	btnPause.classList.remove('on');
});
btnPause.addEventListener('click', () => {
	swiper.autoplay.stop();
	activeBtnPause();
});

[pagination, btnPrev, btnNext].forEach((el) => {
	el.addEventListener('click', () => activeBtnPause());
});

swiper.on('sliderMove', () => activeBtnPause());

window.addEventListener('keydown', (e) => (e.code === 'ArrowRight' || e.code === 'ArrowLeft') && activeBtnPause());
// if (e.code === 'ArrowRight' || e.code === 'ArrowLeft') activeBtnPause();
// });

function activeBtnPause() {
	btnPause.classList.add('on');
	btnPlay.classList.remove('on');
}
