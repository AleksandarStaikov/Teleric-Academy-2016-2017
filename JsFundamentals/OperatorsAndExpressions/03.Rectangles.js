function calculateArea(dimentions) {
	var area = dimentions[0] * dimentions[1];
	var perimeter = dimentions[0] * 2 + dimentions[1] * 2;
	console.log(area.toFixed(2) + ' ' + perimeter.toFixed(2))
}

calculateArea([2.5,3])