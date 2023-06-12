const wrap = document.querySelector('.gallery_wrap .gallery_list');
const api_key = '6c70577e2661042cd0ab587b17f6c944';
const myID = '198484213@N03';
const num = 50;
const baseURL = `https://www.flickr.com/services/rest/?format=json&nojsoncallback=1&api_key=${api_key}&per_page=${num}&method=`;
const method_interest = 'flickr.interestingness.getList';
const method_user = 'flickr.people.getPhotos';
const url_interest = `${baseURL}${method_interest}`;
const url_user = `${baseURL}${method_user}&user_id=${myID}`;

fetch(url_user)
	.then((res) => res.json())
	.then((json) => {
		const items = json.photos.photo;
		console.log(items);
		let tags = '';

		items.forEach((item, idx) => {
			const num = idx + 1;
			tags += `
      <li>
        <div class='gallery_item'>
          <span class='gallery_item__num'>${num}</span>
          <p class='gallery_item__pic'>
            <img class='pic' src='https://live.staticflickr.com/${item.server}/${item.id}_${item.secret}_w.jpg' alt='https://live.staticflickr.com/${item.server}/${item.id}_${item.secret}_b.jpg' />
          </p>
          <p class='gallery_item__title'>${item.title === '' ? 'Have a good day !' : item.title}</p>
        </div>
      </li>
      `;
		});

		wrap.innerHTML = tags;

		const imgs = wrap.querySelectorAll('img');

		let count = 0;

		for (const el of imgs) {
			el.onload = () => {
				count++;

				// 		count === imgs.length && isoLayout();
			};
		}
	});

document.body.addEventListener('click', (e) => {
	if (e.target.className === 'pic') {
		const imgSrc = e.target.getAttribute('alt');
		console.log(imgSrc);
		createPop(imgSrc);
	}
	if (e.target.className === 'close') removePop();
});

// function isoLayout() {
// 	new Isotope(wrap, {
// 		itemSelector: '.item',
// 		transitionDuration: '0.5s',
// 	});
// 	wrap.classList.add('on');
// }

function createPop(imgSrc) {
	const tags = `
		<div class='con'>
			<img class='thumb' src='${imgSrc}'/>
		</div>
		<span class='close'>close</span>
	`;

	const aside = document.createElement('aside');
	aside.classList = 'pop';
	aside.innerHTML = tags;
	document.body.append(aside);
	setTimeout(() => document.querySelector('.pop').classList.add('on'), 0);
	document.body.style.overflow = 'hidden';
}

function removePop() {
	document.querySelector('.pop').classList.remove('on');
	setTimeout(() => document.querySelector('.pop').remove(), 200);
	document.body.style.overflow = 'auto';
}
