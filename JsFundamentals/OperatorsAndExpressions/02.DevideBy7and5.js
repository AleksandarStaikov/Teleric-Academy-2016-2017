function divisable (arr) {
	for (item in arr) {
		if (arr[item] % 5 == 0 && arr[item] % 7 == 0) {
			console.log('true ' + arr[item])
		}else {
			console.log('false ' + arr[item])
		}
	}
}

var arr = [3,35,23,8,1]
divisable(arr)