const wrap = document.querySelector('.member_list_wrap .member_list');

let tags = '';

fetch('/DB/members.json')
	.then((res) => {
		return res.json();
	})
	.then((data) => {
		const memberData = data.members;

		memberData.map((data) => {
			tags += `
				<li class='member_item'>
					<div class='member_item__info'>
						<h2 class='member_item__title'><span>${data.name}</span></h2>
						<p class='member_item__desc'>${data.position}</p>
					</div>
					<div class='member_item__img'>
						<img src='img/${data.pic}' />
					</div>
				</li>
      `;
		});
		wrap.innerHTML = tags;
	});
// .catch((err) => {
// 	console.log(err);
// });
