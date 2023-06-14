const form = document.querySelector('#member');
const btnSubmit = form.querySelector('input[type=submit]');

btnSubmit.addEventListener('click', (e) => {
	if (!isTxt('userid', 5)) e.preventDefault();
	if (!isPwd('pwd1', 'pwd2', 4)) e.preventDefault();
	if (!isEmail('email', 6)) e.preventDefault();
	if (!isCheck('gender')) e.preventDefault();
	if (!isCheck('hobby')) e.preventDefault();
	if (!isSelect('edu')) e.preventDefault();
});

function isTxt(name, len) {
	const input = form.querySelector(`[name=${name}]`);
	const txt = input.value.trim();

	if (txt.length < len) {
		resetErr(input);
		const errMsg = document.createElement('p');
		errMsg.innerText = `텍스트를 ${len}글자 이상 입력하세요.`;
		input.closest('td').append(errMsg);
		return false;
	} else {
		resetErr(input);
		return true;
	}
}

function isPwd(pwd1, pwd2, len) {
	const num = /[0-9]/;
	const eng = /[a-zA-Z]/;
	const spc = /[!@#$%^&*()_+]/;

	const pwdEl1 = form.querySelector(`[name=${pwd1}]`);
	const pwd1_val = form.querySelector(`[name=${pwd1}]`).value;
	const pwd2_val = form.querySelector(`[name=${pwd2}]`).value;

	if (pwd1_val !== pwd2_val || pwd1_val.length < len || !num.test(pwd1_val) || !eng.test(pwd1_val) || !spc.test(pwd1_val)) {
		resetErr(pwdEl1);
		const errMsg = document.createElement('p');
		errMsg.innerText = `비밀번호 ${len}글자 이상, 특수문자, 영문, 숫자를 모두 포함하여 입력하시오`;
		pwdEl1.closest('td').append(errMsg);
		return false;
	} else {
		resetErr(pwdEl1);
		return true;
	}
}

function isEmail(name, len) {
	const email = form.querySelector(`[name=${name}]`);
	const email_val = email.value;

	if (/@/.test(email_val)) {
		console.log('test');
		const [forwardTxt, backwardTxt] = email_val.split('@');

		if (!forwardTxt || !backwardTxt) {
			console.log('test2');
			resetErr(email);
			const errMsg = document.createElement('p');
			errMsg.innerText = `@ 앞쪽이나 뒷쪽에 문자값이 없습니다.`;
			email.closest('td').append(errMsg);
			return false;
		} else {
			if (!/\./.test(backwardTxt)) {
				console.log('test3');
				resetErr(email);
				const errMsg = document.createElement('p');
				errMsg.innerText = `@ 뒤쪽에 서비스명이 올바른지 확인하세요.`;
				email.closest('td').append(errMsg);
				return false;
			} else {
				resetErr(email);
				return true;
			}
		}
	} else {
		resetErr(email);
		const errMsg = document.createElement('p');
		errMsg.innerText = `@포함하여 입력하고 ${len}글자 이상 입력하시오`;
		email.closest('td').append(errMsg);
		return false;
	}
}

function isCheck(name) {
	const inputs = document.querySelectorAll(`[name=${name}]`);
	let isChecked = false;

	for (const input of inputs) input.checked && (isChecked = true);
	if (!isChecked) {
		resetErr(inputs);
		const errMsg = document.createElement('p');
		errMsg.innerText = `해당 항목을 하나 이상 체크하시오.`;
		inputs[0].closest('td').append(errMsg);

		return false;
	} else {
		resetErr(inputs);
		return true;
	}
}

function isSelect(name) {
	const input = form.querySelector(`[name=${name}]`);
	const selected_index = input.options.selectedIndex;
	const value = input.options[selected_index].value;

	if (value === '') {
		resetErr(input);
		const errMsg = document.createElement('p');
		errMsg.innerText = `해당 요소 중 하나를 선택하시오.`;
		input.closest('td').append(errMsg);
		return false;
	} else {
		resetErr(input);
		return true;
	}
}

// 에러 메세지 제거 함수
function resetErr(inputs) {
	// 파라미터로 들어오는 요소의 형태 확인해야함 배열인지 뭔지

	let el = null;
	inputs.length ? (el = inputs[0]) : (el = inputs);
	// 배열인 경우에만 length가 존재

	const errMsg = el.closest('td').querySelector('p');
	if (errMsg) {
		el.closest('td').querySelector('p').remove();
	}
}
