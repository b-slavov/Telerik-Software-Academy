// Problem 1. Odd or Even

function solve(args) {
    if (args % 2 === 0) {
		console.log('even ' + args);
	} else {
		console.log('odd ' + args);
	}
}

// Problem 2. Divisible by 7 and 5

function solve(args) {
    if (args % 35 === 0) {
		console.log('true ' + args);
	} else {
		console.log('false ' + args);
	}
}

// Problem 3. Rectangle's area

function solve(args) {
    var width = +args[0],
        height = +args[1],
        area = width * height
		perimeter = 2 * (width + height);

    console.log(area.toFixed(2) + ' ' + perimeter.toFixed(2));
}

// Problem 4. Third digit

function solve(args) {
    var thirdDigit = (Math.floor(Math.abs(args / 100))) % 10;

    if (thirdDigit === 7) {
		console.log('true');
	} else {
		console.log('false ' + thirdDigit);
	}
}

// Problem 5. Third bit

function solve(args) {
    var thirdBit = (args >> 3) & 1;
	console.log(thirdBit);
}

// Problem 6. Point in Circle

function solve(args) {
    var x = args[0],
        y = args[1],
        r = 2,
		xSqrtPlusYSqrt = x * x + y * y,
        isInCircle = xSqrtPlusYSqrt <= r * r
		distance = Math.sqrt(xSqrtPlusYSqrt).toFixed(2);

    if (isInCircle) {
        console.log('yes ' + distance);
    } else {
        console.log('no ' + distance);
    }
}

// Problem 7. Prime check

function solve(args) {
    var isPrime = true;
	if (args < 2) {
            isPrime = false;
        } else {
		for (var i = 2; i <= Math.floor(Math.sqrt(args)); i += 1) {
			if (args % i === 0) {
				isPrime = false;
				break;
			}
		}
	}
	
	console.log(isPrime);
}

// Problem 8. Trapezoid's area

function solve(args) {
    var a = +args[0],
        b = +args[1],
        h = +args[2],
        area = (a + b) * h / 2;

    console.log(area.toFixed(7));
}

// Problem 9. Point in Circle and outside Rectangle

function solve(args) {
    var x = args[0],
        y = args[1],
        r = 1.5,
        insideCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= r * r,
        insideRectangle = ((x >= -1) && (x <= 5) && (y >= -1) && (y <= 1));
		
    if (insideCircle) {
        if (insideRectangle) {
			console.log('inside circle inside rectangle');
		} else {
			console.log('inside circle outside rectangle');
		}
    } else {
        if (insideRectangle) {
			console.log('outside circle inside rectangle');
		} else {
			console.log('outside circle outside rectangle');
		}
    }
}