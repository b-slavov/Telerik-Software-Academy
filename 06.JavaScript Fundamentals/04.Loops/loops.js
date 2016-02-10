// Problem 1. Numbers

function problem1() {
    var number = document.getElementById('number1').value,
        i;

    if (!isNaN(number) && number !== '' && !(number % 1)) {
        number *= 1;
        document.getElementById('pr1result').innerHTML = 'Result: ';
        console.log('Problem 1: All integers from 1 to ' + number);
        if (number >= 1) {
            for (i = 1; i <= number; i += 1) {
                document.getElementById('pr1result').innerHTML += i;
                console.log(i);
                if (i <= number - 1) {
                    document.getElementById('pr1result').innerHTML += ', ';
                }
            }
        } else {
            for (i = 1; i >= number; i -= 1) {
                document.getElementById('pr1result').innerHTML += i;
                console.log(i);
                if (i > number) {
                    document.getElementById('pr1result').innerHTML += ', ';
                }
            }
        }
    } else {
        document.getElementById('pr1result').innerHTML =
            'Incorrect input! Enter an integer!';
    }

    document.getElementById('number1').value = '';
}

// Problem 2. Numbers not divisible

function problem2() {
    var number = document.getElementById('number2').value,
        i;

    if (!isNaN(number) && number !== '' && !(number % 1)) {
        number *= 1;
        document.getElementById('pr2result').innerHTML = 'Result: ';
        console.log('Problem 2: All integers from 1 to ' + number + ', not divisible by 3 and 7');

        if (number >= 1) {
            for (i = 1; i <= number; i += 1) {
                if (!(!(i % 3) && !(i % 7))) {
                    document.getElementById('pr2result').innerHTML += i;
                    console.log(i);
                    if (i <= number - 1) {
                        document.getElementById('pr2result').innerHTML += ', ';
                    }
                }
            }
        } else {
            for (i = 1; i >= number; i -= 1) {
                if (!(!(i % 3) && !(i % 7))) {
                    document.getElementById('pr2result').innerHTML += i;
                    console.log(i);
                    if (i > number) {
                        document.getElementById('pr2result').innerHTML += ', ';
                    }
                }
            }
        }
    } else {
        document.getElementById('pr2result').innerHTML =
            'Incorrect input. Enter an integer.';
    }

    document.getElementById('number2').value = '';
}

// Problem 3. Min/Max of sequence

function problem3() {
    var input = document.getElementById('array').value,
        validInput = true,
        max,
        min,
        arr,
        i,
        len;

    if (input === '') {
        validInput = false;
    } else {
        arr = input.split(', ').map(Number);
        for (i = 0, len = arr.length; i < len; i += 1) {
            if (isNaN(arr[i])) {
                validInput = false;
                break;
            }
        }
    }

    if (validInput) {
        max = min = arr[0];
        for (i = 0, len = arr.length; i < len; i += 1) {
            if (arr[i] > max) {
                max = arr[i];
            }
            if (arr[i] < min) {
                min = arr[i];
            }
        }
        document.getElementById('pr3result').innerHTML = 'Result: Min: ' + min + '; Max: ' + max;
        console.log('Problem 3: Min: ' + min + '; Max: ' + max);
    } else {
        document.getElementById('pr3result').innerHTML = 'Invalid input';
    }
    document.getElementById('array').value = '';
}

// Problem 4. Lexicographically smallest

function problem4() {
    var smallest = 'zzz',
        largest = '',
        result,
        prop;

    for (prop in document) {
        if (prop < smallest) {
            smallest = prop;
        }
        if (prop > largest) {
            largest = prop;
        }
    }

    result = 'Result:<br>Document: smallest: ' + smallest + '; largest: ' + largest;
    console.log('Document: smallest: ' + smallest + '; largest: ' + largest);
    smallest = 'zzz';
    largest = '';

    for (prop in window) {
        if (prop < smallest) {
            smallest = prop;
        }
        if (prop > largest) {
            largest = prop;
        }
    }

    result += '<br>Window: smallest: ' + smallest + '; largest: ' + largest;
    console.log('Window: smallest: ' + smallest + '; largest: ' + largest);
    smallest = 'zzz';
    largest = '';

    for (prop in navigator) {
        if (prop < smallest) {
            smallest = prop;
        }
        if (prop > largest) {
            largest = prop;
        }
    }

    result += '<br>Navigator: smallest: ' + smallest + '; largest: ' + largest;
    console.log('Navigator: smallest: ' + smallest + '; largest: ' + largest);
    document.getElementById('pr4result').innerHTML = result;
}