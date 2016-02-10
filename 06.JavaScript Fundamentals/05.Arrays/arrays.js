// Problem 1. Increase array members

function problem1() {
    var arr = [],
        i;

    for (i = 0; i < 20; i += 1) {
        arr[i] = i * 5;
    }

    document.getElementById('pr1result').innerHTML = 'Result: ' + arr.join(', ');
    console.log('Problem 1: ' + arr.join(', '));
}

// Problem 2. Lexicographically comparison

function problem2() {
    var string1 = document.getElementById('string1').value,
        string2 = document.getElementById('string2').value,
        string1len,
        string2len,
        i,
        result = '';

    if (string1 !== '' && string2 !== '') {
        string1len = string1.length;
        string2len = string2.length;

        for (i = 0; i < Math.min(string1len, string2len); i += 1) {
            if (string1[i] < string2[i]) {
                result = string1 + ' < ' + string2;
                break;
            }
            if (string1[i] > string2[i]) {
                result = string2 + ' < ' + string1;
                break;
            }
        }

        if (result === '') {
            if (string1len < string2len) {
                result = string1 + ' < (comes before) ' + string2;
            } else if (string1len > string2len) {
                result = string2 + ' < (comes before) ' + string1;
            } else {
                result = string1 + ' = ' + string2;
            }
        }

        document.getElementById('pr2result').innerHTML = 'Result: ' + result;
        console.log('Problem 2: ' + result);

    } else {
        document.getElementById('pr2result').innerHTML = 'Please enter two strings';
    }

    document.getElementById('string1').value = '';
    document.getElementById('string2').value = '';
}

// Problem 3. Maximal sequence

function problem3() {
    var input = document.getElementById('array3').value,
        validInput = validateInput(input),
        max = 1,
        currentMax = 1,
        maxEndIndex = 0,
        arr,
        i,
        len,
        maxSequence;

    if (validInput) {
        arr = input.split(', ').map(Number);

        for (i = 1, len = arr.length; i < len; i += 1) {
            if (arr[i] === arr[i - 1]) {
                currentMax += 1;
                if (currentMax > max) {
                    max = currentMax;
                    maxEndIndex = i;
                }
            } else {
                currentMax = 1;
            }
        }
        maxSequence = arr.splice(maxEndIndex - max + 1, max).join(', ');
        document.getElementById('pr3result').innerHTML = 'Result: ' + maxSequence;
        console.log('Problem 3: ' + maxSequence);
    } else {
        document.getElementById('pr3result').innerHTML = 'Invalid input';
    }
    document.getElementById('array3').value = '';
}

// Problem 4. Maximal increasing sequence

function problem4() {
    var input = document.getElementById('array4').value,
        validInput = validateInput(input),
        max = 1,
        currentMax = 1,
        maxEndIndex = 0,
        arr,
        i,
        len,
        maxSequence;

    if (validInput) {
        arr = input.split(', ').map(Number);
        for (i = 1, len = arr.length; i < len; i += 1) {
            if (arr[i] > arr[i - 1]) {
                currentMax += 1;
                if (currentMax > max) {
                    max = currentMax;
                    maxEndIndex = i;
                }
            } else {
                currentMax = 1;
            }
        }
        maxSequence = arr.splice(maxEndIndex - max + 1, max).join(', ');
        document.getElementById('pr4result').innerHTML = 'Result: ' + maxSequence;
        console.log('Problem 4: ' + maxSequence);
    } else {
        document.getElementById('pr4result').innerHTML = 'Invalid input';
    }
    document.getElementById('array4').value = '';
}

// Problem 5. Selection sort

function problem5() {
    var input = document.getElementById('array5').value,
        validInput = validateInput(input),
        temp,
        arr,
        i,
        j,
        min,
        len,
        result;

    if (validInput) {
        arr = input.split(', ').map(Number);
        result = 'Input array: ' + arr.join(', ');

        for (i = 0, len = arr.length; i < len; i += 1) {
            for (j = i + 1; j < len; j += 1) {
                if (arr[i] > arr[j]) {
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
        }

        result += '; Sorted array: ' + arr.join(', ');
        document.getElementById('pr5result').innerHTML = 'Result: ' + result;
        console.log('Problem 5: ' + result);

    } else {
        document.getElementById('pr5result').innerHTML = 'Invalid input';
    }
    document.getElementById('array5').value = '';
}

// Problem 6. Most frequent number

function problem6() {
    var input = document.getElementById('array6').value,
        validInput = validateInput(input),
        mostFrequent,
        current,
        mostFrequentCount = 0,
        currentCount = 0,
        arr,
        i,
        j,
        len,
        result;

    if (validInput) {
        arr = input.split(', ').map(Number);
        for (i = 0, len = arr.length; i < len; i += 1) {
            current = arr[i];
            currentCount = 0;
            for (j = i; j < len; j += 1) {
                if (arr[j] === current) {
                    currentCount += 1;
                    if (currentCount > mostFrequentCount) {
                        mostFrequentCount = currentCount;
                        mostFrequent = current;
                    }
                }
            }
        }

        result = mostFrequent + ' &#8594 ' + mostFrequentCount + ' times';
        document.getElementById('pr6result').innerHTML = 'Result: ' + result;
        console.log('Problem 6: ' + result);

    } else {
        document.getElementById('pr6result').innerHTML = 'Invalid input';
    }
    document.getElementById('array6').value = '';
}

// Problem 7. Binary search

function problem7() {
    var input = document.getElementById('array7').value,
        number = document.getElementById('number7').value,
        validInput = validateInput(input),
        arr,
        i,
        indexOf,
        num,
        len,
        result;

    if (validInput && number !== '' && !isNaN(number)) {
        arr = input.split(', ').map(Number);
        arr.sort(function(a, b) {
            return a - b;
        });
        number *= 1;
        indexOf = binSearch(arr, number, 0, arr.length - 1);
        result = number + ' has index ' + indexOf;
        document.getElementById('pr7result').innerHTML = 'Result: ' + result;
        console.log('Problem 7: ' + result);
    } else {
        document.getElementById('pr7result').innerHTML = 'Invalid input';
    }
    document.getElementById('array7').value = '';
    document.getElementById('number7').value = '';

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

function validateInput(input) {
    var validInput = true;
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
    return validInput;
}