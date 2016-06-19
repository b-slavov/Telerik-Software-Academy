// Problem 1. Exchange if greater

function solve(args) {
    var a = +args[0],
        b = +args[1];

    if (a > b) {
		a = a + b;
		b = a - b;
		a = a - b;
	}
	
	console.log(a + ' ' + b);
}

// Problem 2. Multiplication Sign

function solve(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2],
        result = a * b * c;

    if (result > 0) {
        console.log('+');
    } else if (result < 0) {
        console.log('-');
    } else {
        console.log(0);
    }
}

// Problem 3. The biggest of Three

function solve(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2],
        max = Math.max(a, b, c);
	
    console.log(max);
}

// Problem 4. Sort 3 numbers

function solve(args) {
    var sorted = args.sort(function(a,b) {
		return b - a
		}).join(' ');
	
    console.log(sorted);
}

// Problem 5. Digit as word

function solve(args) {
	var result;
    switch (+args) {
        case 0: result = 'zero'; break;
        case 1: result = 'one'; break;
        case 2: result = 'two'; break;
        case 3: result = 'three'; break;
        case 4: result = 'four'; break;
        case 5: result = 'five'; break;
        case 6: result = 'six'; break;
        case 7: result = 'seven'; break;
        case 8: result = 'eight'; break;
        case 9: result = 'nine'; break;
		default: result = 'not a digit'; break;
    }
	
	console.log(result);
}

// Problem 6. Quadratic equation

function solve(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2],
		D = b * b - 4 * a * c,
        x,
        x1,
        x2;

	if (D > 0) {
		x1 = (-b - Math.sqrt(D)) / (2 * a);
		x2 = (-b + Math.sqrt(D)) / (2 * a);
		console.log('x1=' + x1.toFixed(2) + '; x2=' + x2.toFixed(2));
	} else if (D === 0) {
		x = -b / (2 * a);
		console.log('x1=x2=' + x.toFixed(2));
	} else {
		console.log('no real roots');
	}
}

// Problem 7. The biggest of five numbers

function solve(args) {
    var max = Math.max.apply(Math, args);

    console.log(max);
}

// Problem 8. Number as words

function solve(args) {
    var number = +args[0],
		units = [ 'zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine' ],
		unique = [ 'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen' ],
		tenths = [ 'ten', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety' ],
		result;
		
	if (number < 10) {
		result = units[number];
	} else if (number < 100) {
		if (number >= 11 && number <= 19) {
			result = unique[number % 10 - 1];
		} else if (number % 10 === 0) {
			result = tenths[Math.floor(number / 10) - 1];
		} else {
			result = tenths[Math.floor(number / 10) - 1] + ' ' + units[number % 10];
		}
    } else {
		result = units[Math.floor(number / 100)] + ' hundred';
		breakme: if (number % 100 === 0) {
		} else if (number % 100 >= 11 && number % 100 <= 19) {
			result += ' and ' + unique[number % 10 - 1];
		} else if (number % 10 === 0) {
			result += ' and ' + tenths[(Math.floor(number / 10)) % 10 - 1];
		} else if ((Math.floor(number / 10)) % 10 === 0) {
			result += ' and ' + units[number % 10];
		} else {
			result += ' and ' + tenths[(Math.floor(number / 10)) % 10 - 1] + ' ' + units[number % 10];
		}
    }
		
	String.prototype.capitalizeFirstLetter = function() {
		return this.charAt(0).toUpperCase() + this.slice(1);
	}
	
	console.log(result.capitalizeFirstLetter());
}