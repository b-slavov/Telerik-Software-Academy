// Problem 1. Say Hello

function solve(args) {
	return 'Hello, ' + args + '!';
}

// Problem 2. Get largest number

function solve(args) {
	var input = args[0].split(' ').map(Number);
	
	return Math.max.apply(null, input);
}

// Problem 3. English digit

function solve(args) {
    var input = +args % 10,
		numbers = [ 'zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine' ];
	
	return numbers[input];
}

// Problem 4. Appearance count

function solve(args) {
    var input = args[0].split('\n'),
		sequenceLength = input[0],
		sequence = input[1].split(' ').map(Number),
		x = +input[2],
		counter = 0,
		i;
	
    for (i = 0; i < sequenceLength; i++)
	{
		if (sequence[i] === x) {
			counter++;
		}
	}
	
	return counter;
}

// Problem 5. Larger than neighbours

function solve(args) {
    var input = args[0].split('\n'),
		sequenceLength = input[0],
		sequence = input[1].split(' ').map(Number),
		counter = 0,
		i;
	
    for (i = 1; i < sequenceLength - 1; i++)
	{
		if (sequence[i] > sequence[i - 1] && sequence[i] > sequence[i + 1]) {
			counter++;
		}
	}
	
	return counter;
}

// Problem 6. First larger than neighbours

function solve(args) {
    var input = args[0].split('\n'),
		sequenceLength = input[0],
		sequence = input[1].split(' ').map(Number),
		i;
	
    for (i = 1; i < sequenceLength - 1; i++)
	{
		if (sequence[i] > sequence[i - 1] && sequence[i] > sequence[i + 1]) {
			return i;
		} else if (i === sequenceLength - 2) {
			return -1;
		}
	}
}

// Problem 7. Sorting array

function solve(args) {
    var input = args[0].split('\n'),
		sequenceLength = input[0],
		sequence = input[1].split(' ').map(Number),
		i;
	
    sequence.sort(function(a, b) {
		return a-b
		});

	return sequence.join(' ');
}