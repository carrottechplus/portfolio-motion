const wrap = document.querySelector('.sub_wrap .youtube_wrap .gallery_list');

fetchData();

document.body.addEventListener('click', (e) => {
	// console.log(e.target.className === 'gallery_item');
	if (e.target.className === 'gallery_item__img') createPop(e.target.getAttribute('data-id'));
	if (e.target.className === 'close') removePop();
});

async function fetchData() {
	const key = 'AIzaSyC4TpEbx2d9lOtjiVQIg3b6wA6ZKKrDL7c';
	const list = 'PLQZTVbf9_qAn_Nwrz2maZG64AaEBcFZfb';
	const num = 10;
	const url = `https://www.googleapis.com/youtube/v3/playlistItems?part=snippet&playlistId=${list}&key=${key}&maxResults=${num}`;

	const data = await fetch(url);
	const json = await data.json();

	createList(json.items);
}

function createList(arr) {
	let tags = '';
	arr.forEach((item) => {
		// console.log(item);
		const title = item.snippet.title;
		const desc = item.snippet.description;
		const name = item.snippet.videoOwnerChannelTitle;
		const date = item.snippet.publishedAt;

		const channelId = item.snippet.resourceId.videoId;
		const thumbUrl = item.snippet.thumbnails.standard.url;

		tags += `
        <li>
          <div class='gallery_item'>
						<div class='gallery_item__img' data-id='${channelId}'>
							<img src='${thumbUrl}' class='gallery_img'>
						</div>
						<div class='gallery_item__side gallery_side'>
							<h2 class='gallery_side__title'>${title.length > 70 ? title.substr(0, 90) + '...' : title}</h2>
							<p class='gallery_side__desc'>${desc.length > 200 ? desc.substr(0, 200) + '...' : desc}</p>
							
							<div class='gallery_side__info gallery_info'>
								<span class='gallery_info__name'>${name}</span>
								<span class='gallery_info__date'>${date.split('T')[0].split('-').join('.')}</span>
							</div>
						</div>
          </div>
        </li>
      `;
	});

	wrap.innerHTML = tags;
}

function createPop(id) {
	const tags = `	
			<div class='con'>
				<iframe src='https://www.youtube.com/embed/${id}' ></iframe>
			</div>
			<span class='close'>close</span>
	`;
	const pop = document.createElement('aside');
	pop.className = 'pop';
	pop.innerHTML = tags;

	document.body.append(pop);
	setTimeout(() => document.querySelector('.pop').classList.add('on'), 0);
	document.body.style.overflow = 'hidden';
}

function removePop() {
	document.querySelector('.pop').classList.remove('on');
	setTimeout(() => document.querySelector('.pop').remove(), 1000);
	document.body.style.overflow = 'auto';
}
