const wrap = document.querySelector('.sub_wrap .youtube_wrap .gallery_list');
const key = 'AIzaSyC4TpEbx2d9lOtjiVQIg3b6wA6ZKKrDL7c';
const list = 'PLQZTVbf9_qAn_Nwrz2maZG64AaEBcFZfb';
const num = 10;
const url = `https://www.googleapis.com/youtube/v3/playlistItems?part=snippet&playlistId=${list}&key=${key}&maxResults=${num}`;

document.body.addEventListener('click', (e) => {
	// e.preventDefault();
	console.log(e.target.className === 'gallery_item');
	if (e.target.className === 'gallery_item') createPop(e.target.getAttribute('data-id'));

	if (e.target.className === 'close') removePop();
});

// 유튜브 플레이 리스트 가져오기 (fetch)
// 가져온 리스트 화면에 뿌리기

fetch(url)
	.then((data) => data.json())
	.then((json) => {
		//json으로 변환한 데이타 처리 => innerHtml로 tag를 만든다.
		// console.log(json);
		// console.log(json.items);

		createList(json);
	});

// async function fetchData() {
// 	const key = 'AIzaSyC4TpEbx2d9lOtjiVQIg3b6wA6ZKKrDL7c';
// 	const list = 'PLQZTVbf9_qAn_Nwrz2maZG64AaEBcFZfb';
// 	const num = 10;
// 	const url = `https://www.googleapis.com/youtube/v3/playlistItems?part=snippet&playlistId=${list}&key=${key}&maxResults=${num}`;

// 	const data = await fetch(url);
// 	const json = await data.json();
// 	createList(json);
// }

function createList(json) {
	let tags = '';
	json.items.forEach((data) => {
		// console.log(data);
		const title = data.snippet.title;
		const desc = data.snippet.description;
		const name = data.snippet.videoOwnerChannelTitle;
		const date = data.snippet.publishedAt;

		const channelId = data.snippet.resourceId.videoId;
		const thumbUrl = data.snippet.thumbnails.standard.url;

		tags += `
        <li>
          <div class='gallery_item' data-id='${channelId}'>
						<div class='gallery_item__img'>
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

//동적으로 팝업 생성함수
function createPop(id) {
	// console.log(id);
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
