const wrap = document.querySelector('.gallery_wrap .gallery_list');
const loading = document.querySelector('.gallery_wrap .loading');
const api_key = '6c70577e2661042cd0ab587b17f6c944';
const myID = '198484213@N03';
const num = 50;

const baseURL = `https://www.flickr.com/services/rest/?format=json&nojsoncallback=1&api_key=${api_key}&per_page=${num}&method=`;
const method_interest = 'flickr.interestingness.getList';
const method_user = 'flickr.people.getPhotos';

const url_interest = `${baseURL}${method_interest}`;
const url_user = `${baseURL}${method_user}&user_id=${myID}`;

// fetch(url_interest)
// 	.then((res) => res.json())
// 	.then((json) => {
// 		// loading.classList.remove('off');
// 	});
fetchData(url_interest);

async function fetchData(url) {
	const res = await fetch(url);
	const json = await res.json();
	const items = json.photos.photo;
	// console.log(items);

	createList(items);
}

function createList(arr) {
	let tags = '';

	arr.forEach((item, idx) => {
		const num = idx + 1;
		tags += `
		<li class='item'>
			<div class='gallery_item'>
				<span class='gallery_item__num'>${num}</span>
				<p class='gallery_item__pic'>
					<img class='pic' src='https://live.staticflickr.com/${item.server}/${item.id}_${item.secret}_w.jpg' alt='https://live.staticflickr.com/${item.server}/${item.id}_${item.secret}_b.jpg' />
				</p>
				<div class='gallery_item__profile gallery_profile'>	
					<p class='gallery_profile__img'><img src='http://farm${item.farm}.staticflickr.com/${item.server}/buddyicons/${item.owner}.jpg' /></p>
					<p class='gallery_profile__title'>${item.title === '' ? 'Have a good day !' : item.title}</p>
					<span class='gallery_profile__name'>${item.owner}</span>
				</div>
			</div>
		</li>
		`;
	});

	wrap.innerHTML = tags;
	setLoading();
}

document.body.addEventListener('click', (e) => {
	if (e.target.className === 'pic') {
		const imgSrc = e.target.getAttribute('alt');
		console.log(imgSrc);
		createPop(imgSrc);
	}
	if (e.target.className === 'close') removePop();
});

function isoLayout() {
	new Isotope(wrap, {
		itemSelector: '.item',
		transitionDuration: '0.5s',
	});
	wrap.classList.add('on');
	loading.classList.add('off');
}

function setLoading() {
	const imgs = wrap.querySelectorAll('img');

	let count = 0;
	for (const el of imgs) {
		el.onerror = () => {
			el.setAttribute('src', 'https://www.flickr.com/images/buddyicon.gif');
		};
		el.onload = () => {
			count++;
			count === imgs.length && isoLayout();
		};
	}
}

function createPop(imgSrc) {
	const tags = `
		<div class='con'>
			<img class='thumb' src='${imgSrc}'/>
		</div>
		<span class='close'>close</span>
	`;

	const aside = document.createElement('aside');
	aside.className = 'pop';
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
