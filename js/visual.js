console.log('pageYOffset', window.pageYOffset);
console.log('offsetHeight', document.body.offsetHeight);
console.log('innerHeight', window.innerHeight);
console.log('scrollTop', document.documentElement.scrollTop);

window.addEventListener('scroll', () => {
	const num = window.pageYOffset / (document.body.offsetHeight - window.innerHeight);

	const visual = document.querySelector('.intro_visual__img');
	const bottom = document.querySelector('.intro_bottom');
	const bottom_scroll = document.querySelector('.intro_bottom').offsetTop;
	let scrollLocation = document.documentElement.scrollTop;

	const scroll = window.scrollY;
	let top = visual.offsetTop - 100;
	let scroll2 = scroll - visual.offsetTop;
	const compStyles = window.getComputedStyle(visual);
	let height1 = compStyles.getPropertyValue('height');
	// console.log(parseInt(compStyles.getPropertyValue('height')));
	// const number = parseInt(compStyles.getPropertyValue('padding-top'));
	// const number2 = (number * scroll2) / (top - bottom.offsetTop);
	// const number3 = number - number2;

	if (scrollLocation >= top && bottom_scroll > scrollLocation) {
		let test = scrollLocation - top;
		console.log(test, 'test');

		let height2 = parseInt(visual.style.height.replaceAll(/[^0-9]/g, ''));
		console.log(height2, 'height2');
		if (test < height2) {
			console.log('작아짐');
			visual.style.height = parseInt(height2 - test) + 'px';
		} else {
			console.log('커짐');
			// visual.style.height = parseInt(height2 + test) + 'px';
		}
		visual.classList.add('now');
		// visual.style.paddingTop = number / numbe + 'px';
	} else {
		visual.classList.remove('now');
		// visual.style.paddingTop = number + '%';
	}
});
