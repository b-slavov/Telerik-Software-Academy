// Problem 1. Numbers

function solve(args) {
    var n = +args,
		i,
		foo = new Array(n);

    for (i = 1; i <= n; i += 1) {
		foo[i - 1] = i;
	}
	
	console.log(foo.join(' '));
}

// Problem 2. MMSA

function solve(args) {
    var min = +args[0],
		max = +args[0],
		sum = 0,
		avg = 0,
		i,
		n;
    
    for (i = 0; i < args.length; i++) {
        n = +args[i];
        if (n < min) {
            min = n;
        }
		
        if (n > max) {
            max = n;
        }
		
		sum += n;
    }
	
    avg = sum / args.length;
	
    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + avg.toFixed(2));
}

// Problem 3. Matrix of numbers

function solve(args) {
    var n = +args,
		row = '',
		i,
		j;

    for (i = 1; i <= n; i++) {
        for (j = i; j <= n + (i - 1); j++) {
            row += j + ' ';
        }
		
        console.log(row);
        row ='';
    }
}

// Problem 5. Hex to decimal

function solve(args) {
    var hex = args[0],
		res = 0,
		dec = 1,
		symbol;

    for (var i = hex.length - 1; i >= 0; i--) {
        symbol = hex[i];
        if (+symbol >= 0 && +symbol < 10) {
            res += +symbol * dec;
            dec *= 16;
        } else if (symbol == 'A') {
            res += 10 * dec;
            dec *= 16;
        } else if (symbol == 'B') {
            res += 11 * dec;
            dec *= 16;
        } else if (symbol == 'C') {
            res += 12 * dec;
            dec *= 16;
        } else if (symbol == 'D') {
            res += 13 * dec;
            dec *= 16;
        } else if (symbol == 'E') {
            res += 14 * dec;
            dec *= 16;
        } else if (symbol == 'F') {
            res += 15 * dec;
            dec *= 16;
        }
    }
	
    console.log(res);
}