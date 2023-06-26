const wrap = document.querySelector('.gallery_wrap .gallery_list');
const loading = document.querySelector('.gallery_wrap .loading');
const api_key = '6c70577e2661042cd0ab587b17f6c944';
const myID = '198484213@N03';
const num = 50;
const searchInput = document.querySelector('.gallery_wrap #search');
const searchBtn = document.querySelector('.gallery_wrap .searchBtn');
const btnInterest = document.querySelector('.gallery_wrap .btnInterest');
const btnMine = document.querySelector('.gallery_wrap .btnMine');

btnInterest.classList.add('on');
fetchData(setURL('interest'));

searchBtn.addEventListener('click', (e) => {
	// e.preventDefault();
	getSearch();
});

searchInput.addEventListener('keypress', (e) => e.code === 'Enter' && getSearch());

wrap.addEventListener('click', (e) => {
	if (e.target.className === 'gallery_profile__id') {
		menuActive();
		fetchData(setURL('user', e.target.innerText));
	}

	// if (e.target.className === 'thumb') createPop(e.target.getAttribute('alt'));
});

btnInterest.addEventListener('click', () => {
	menuActive();
	btnInterest.classList.add('on');
	fetchData(setURL('interest'));
});
btnMine.addEventListener('click', () => {
	menuActive();
	btnMine.classList.add('on');
	fetchData(setURL('user', myID));
});

function getSearch() {
	const value = searchInput.value.trim();
	searchInput.value = '';
	if (value === '') {
		return alert('검색어를 입력해 주세요.');
	}
	menuActive();

	fetchData(setURL('search', value));
}

function menuActive(el) {
	document.querySelectorAll('.gallery_wrap button').forEach((el) => {
		if (el.classList.contains('on')) {
			el.classList.remove('on');
		}
	});
}

function setURL(type, opt) {
	const baseURL = `https://www.flickr.com/services/rest/?format=json&nojsoncallback=1&api_key=${api_key}&per_page=${num}&method=`;
	const method_interest = 'flickr.interestingness.getList';
	const method_user = 'flickr.people.getPhotos';
	const method_search = 'flickr.photos.search';

	if (type === 'interest') return `${baseURL}${method_interest}`;
	if (type === 'search') return `${baseURL}${method_search}&tags=${opt}`;
	if (type === 'user') return `${baseURL}${method_user}&user_id=${opt}`;
}

async function fetchData(url) {
	loading.classList.remove('off');
	document.body.style.overflow = 'hidden';
	wrap.classList.remove('on'); //Isotope

	const res = await fetch(url);
	const json = await res.json();
	const items = json.photos.photo;
	// console.log(items);
	if (items.length === 0) {
		loading.classList.add('off');
		document.body.style.overflow = 'auto';
		wrap.classList.add('on');
		return alert('검색 결과가 없습니다.');
	}
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
					<img class='pic' src='https://live.staticflickr.com/${item.server}/${item.id}_${
			item.secret
		}_w.jpg' alt='https://live.staticflickr.com/${item.server}/${item.id}_${item.secret}_b.jpg' />
				</p>
				<div class='gallery_item__profile gallery_profile'>	
					<p class='gallery_profile__img'><img src='http://farm${item.farm}.staticflickr.com/${item.server}/buddyicons/${
			item.owner
		}.jpg' /></p>
					<span class='gallery_profile__id'>${item.owner}</span>
					<p class='gallery_profile__title'>${item.title === '' ? 'Have a good day !' : item.title}</p>
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
	document.body.style.overflow = 'auto';
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
