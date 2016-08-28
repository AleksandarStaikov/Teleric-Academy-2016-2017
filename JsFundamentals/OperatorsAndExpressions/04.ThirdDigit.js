function ThirdDigit (int) {
	int = int / 100;
	int = Math.floor(int)
	var thirdDigit = int % 10;
	if (thirdDigit == 7) {
		console.log(true);
	}else {
		console.log('false ' + thirdDigit)
	}
}

ThirdDigit(711)