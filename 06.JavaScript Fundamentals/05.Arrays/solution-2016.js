// Problem 1. Increase array members

function solve(args) {
    for (i = 0; i < +args; i++) {
        console.log(i * 5);
    }
}

// Problem 2. Lexicographically comparison

function solve(args) {
	var input = args[0].split('\n'),
	firstInput = input[0],
	secondInput = input[1];

	if (firstInput > secondInput) {
		return '>';
	} else if (firstInput < secondInput) {
		return '<';
	} else {
		return '=';
	}
}

// Problem 3. Maximal sequence

function solve(args) {
	var input = args[0].split('\n').map(Number),
		max = 1,
        currentMax = 1,
        i;

	for (i = 1; i < input.length; i++) {
		if (input[i] === input[i - 1]) {
			currentMax++;
			if (currentMax > max) {
				max = currentMax;
			}
		} else {
			currentMax = 1;
		}
	}
	
	console.log(max);
}

// Problem 4. Maximal increasing sequence

function solve(args) {
    var input = args[0].split('\n').map(Number),
        max = 1,
        currentMax = 1,
        i;

	for (i = 1; i < input.length; i++) {
		if (input[i] > input[i - 1]) {
			currentMax++;
			if (currentMax > max) {
				max = currentMax;
			}
		} else {
			currentMax = 1;
		}
	}
	
	return max;
}

// Problem 5. Selection sort

function solve(args) {
    var input = args[0].split('\n').map(Number),
        temp,
        i,
        j;

	for (i = 1; i < input.length; i++) {
		for (j = i + 1; j < input.length; j++) {
			if (input[i] > input[j]) {
				temp = input[j];
				input[j] = input[i];
				input[i] = temp;
			}
		}
	}

	input.shift();
	return input.join('\n');
}

// Problem 6. Most frequent number

function solve(args) {
    var input = args[0].split('\n').map(Number),
		currentCount,
        mostFrequentCount = 0,
		mostFrequentNumber,
		current,
        i,
		j;

	for (i = 1; i < input.length; i++) {
		currentCount = 0;
		for (j = i; j < input.length; j++) {
			if (input[j] === input[i]) {
				currentCount++;
				if (currentCount >= mostFrequentCount) {
					mostFrequentCount = currentCount;
					mostFrequentNumber = input[i];
				}
			}
		}
	}
	
	return mostFrequentNumber + ' (' + mostFrequentCount + ' times)';
}

// Problem 7. Binary search

function solve(args) {
    var input = args[0].split('\n').map(Number),
		x = input[input.length - 1],
        indexOfX,
        i;

	input.shift();
	input.pop();
	input.sort(function(a, b) {
		return a - b;
	});
	
	indexOfX = binSearch(input, x, 0, input.length - 1);
	return indexOfX;

    function binSearch(array, number, start, end) {
        if (array[start] > number || number > array[end]) {
            return (-1);
        }
		
        var middle = ((end + start) / 2) | 0;
        if (array[middle] === number) {
            return middle;
        } else {
            if (array[middle] > number) {
                return binSearch(array, number, start, (middle - 1));
            } else {
                return binSearch(array, number, (middle + 1), end);
            }
        }
    }
}

// Problem 10. Prime numbers

function solve(args) {
    var i = +args,
		j,
		isPrime;
		
	for (i; i >= 2; i--) {
		for (j = 2; j <= Math.floor(Math.sqrt(i)); j++) {
			if (i % j === 0) {
				isPrime = false;
				break;
			} else {
				isPrime = true;
			}
		}
		
		if (isPrime) {
			return i;
		}
	}
}