function isTxt(form, name, len) {
	const input = form.querySelector(`[name=${name}]`);
	if (!input) return;

	const txt = input.value.trim();

	if (txt.length < len) {
		resetErr(input);
		const errMsg = document.createElement('p');
		errMsg.innerText = `텍스트를 ${len}글자 이상 입력하시오`;
		input.closest('td').append(errMsg);
		input.focus();
		return false;
	} else {
		resetErr(input);
		return true;
	}
}

function isPwd(form, pwd1, pwd2, len) {
	const num = /[0-9]/;
	const eng = /[a-zA-Z]/;
	const spc = /[!@#$%^&*()_+]/;

	const pwdEl1 = form.querySelector(`[name=${pwd1}]`);
	const pwdEl2 = form.querySelector(`[name=${pwd2}]`);
	if (!pwdEl1 || !pwdEl2) return;
	const pwd1_val = pwdEl1.value;
	const pwd2_val = pwdEl2.value;

	if (
		pwd1_val !== pwd2_val ||
		pwd1_val.length < len ||
		!num.test(pwd1_val) ||
		!eng.test(pwd1_val) ||
		!spc.test(pwd1_val)
	) {
		resetErr(pwdEl1);
		const errMsg = document.createElement('p');
		errMsg.innerText = `비밀번호 ${len}글자 이상, 특수문자, 영문, 숫자를 모두 포함하여 입력하시오`;
		pwdEl1.closest('td').append(errMsg);
		pwdEl1.focus();
		return false;
	} else {
		resetErr(pwdEl1);
		return true;
	}
}

function isNum(form, phone, len) {
	const num = /[0-9]/;

	const phoneEl = form.querySelector(`[name=${phone}]`);
	const phone_val = form.querySelector(`[name=${phone}]`).value;
	if (!phoneEl) return;

	if (phone_val.length < len || !num.test(phone_val)) {
		resetErr(phoneEl);
		const errMsg = document.createElement('p');
		errMsg.innerText = `휴대폰 번호 ${len}글자 이상, 숫자만 입력하시오`;
		phoneEl.closest('td').append(errMsg);
		phoneEl.focus();
		return false;
	} else {
		resetErr(phoneEl);
		return true;
	}
}

function isEmail(form, name, len) {
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
			email.focus();
			return false;
		} else {
			if (!/\./.test(backwardTxt)) {
				console.log('test3');
				resetErr(email);
				const errMsg = document.createElement('p');
				errMsg.innerText = `@ 뒤쪽에 서비스명이 올바른지 확인하세요.`;
				email.closest('td').append(errMsg);
				email.focus();
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
		email.focus();
		return false;
	}
}

function isCheck(form, name) {
	const inputs = document.querySelectorAll(`[name=${name}]`);
	if (!inputs) return;
	let isChecked = false;

	for (const input of inputs) input.checked && (isChecked = true);
	if (!isChecked) {
		resetErr(inputs);
		const errMsg = document.createElement('p');
		errMsg.innerText = `해당 항목을 하나 이상 체크하시오.`;
		inputs[0].closest('td').append(errMsg);
		inputs[0].focus();

		return false;
	} else {
		resetErr(inputs);
		return true;
	}
}

function isSelect(form, name) {
	const input = form.querySelector(`[name=${name}]`);
	if (!input) return;

	const selected_index = input.options.selectedIndex;
	const value = input.options[selected_index].value;

	if (value === '') {
		resetErr(input);
		const errMsg = document.createElement('p');
		errMsg.innerText = `해당 요소 중 하나를 선택하시오.`;
		input.closest('td').append(errMsg);
		input.focus();
		return false;
	} else {
		resetErr(input);
		return true;
	}
}

function resetErr(inputs) {
	let el = null;
	inputs.length ? (el = inputs[0]) : (el = inputs);

	const errMsg = el.closest('td').querySelector('p');
	if (errMsg) {
		el.closest('td').querySelector('p').remove();
	}
}
