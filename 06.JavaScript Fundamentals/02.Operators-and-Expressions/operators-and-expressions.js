// Problem 1. Odd or Even

function problem1() {
    var problem1Input = document.getElementById('problem1').value,
        isOdd = false;

    if (!isNaN(problem1Input) && problem1Input % 1 === 0 && problem1Input !== '') {
        if (problem1Input % 2 === 0) {
            isOdd = false;
            document.getElementById('pr1result').innerHTML =
                'Result: ' + problem1Input + ' is odd? &#8594 ' + isOdd;
            console.log('Problem 1: ' + problem1Input + ' is odd? &#8594 ' + isOdd);
        } else {
            isOdd = true;
            document.getElementById('pr1result').innerHTML =
                'Result: ' + problem1Input + ' is odd? &#8594 ' + isOdd;
            console.log('Problem 1: ' + problem1Input + ' is odd? &#8594 ' + isOdd);
        }
    } else {
        document.getElementById('pr1result').innerHTML =
            'Input is not an integer!';
    }

    document.getElementById('problem1').value = '';
}

// Problem 2. Divisible by 7 and 5

function problem2() {
    var problem2Input = document.getElementById('problem2').value,
        isDivisibleBy5and7 = false;

    if (!isNaN(problem2Input) && problem2Input % 1 === 0 && problem2Input !== '') {
        if (problem2Input % 5 === 0 && problem2Input % 7 === 0) {
            isDivisibleBy5and7 = true;
        } else {
            isDivisibleBy5and7 = false;
        }
        document.getElementById('pr2result').innerHTML =
            'Result: ' + problem2Input + ' is divisible by 7 and 5. &#8594 ' + isDivisibleBy5and7;
        console.log('Problem 2: ' + problem2Input + ' is divisible by 7 and 5. &#8594 ' + isDivisibleBy5and7);
    } else {
        document.getElementById('pr2result').innerHTML =
            'Input is not an integer!';
    }

    document.getElementById('problem2').value = '';
}

// Problem 3. Rectangle area

function problem3() {
    var width = document.getElementById('rect-width').value,
        height = document.getElementById('rect-height').value,
        area = width * height;

    if (!isNaN(width) && width > 0 &&
        !isNaN(height) && height > 0 &&
        width !== '' && height !== '') {
        document.getElementById('pr3result').innerHTML =
            'Result: ' + width + '*' + height + '=' + area;
        console.log('Problem 3: Rectangle area is: ' + width + '*' + height + '=' + area);
    } else {
        document.getElementById('pr3result').innerHTML =
            'Width and height must be positive numbers!';
    }

    document.getElementById('rect-width').value = '';
    document.getElementById('rect-height').value = '';
}

// Problem 4. Third digit

function problem4() {
    var problem4Input = document.getElementById('problem4').value;
    var thirdDigitIs7 = false;
    var modifiedInput = Math.floor(Math.abs(problem4Input / 100));

    if (!isNaN(problem4Input) && problem4Input % 1 === 0 && problem4Input !== '') {
        if (modifiedInput % 10 === 7) {
            thirdDigitIs7 = true;
        } else {
            thirdDigitIs7 = false;
        }
        document.getElementById('pr4result').innerHTML =
            'Result: Third digit of ' + problem4Input + ' is 7. &#8594 ' + thirdDigitIs7;
        console.log('Problem 4: Third digit of ' + problem4Input + ' is 7. &#8594 ' + thirdDigitIs7);
    } else {
        document.getElementById('pr4result').innerHTML =
            'Input is not an integer!';
    }

    document.getElementById('problem4').value = '';
}

// Problem 5. Third bit

function problem5() {
    var problem5Input = document.getElementById('problem5').value;
    var binaryNumber = parseInt(problem5Input).toString(2).padLeft(16, '0');

    if (!isNaN(problem5Input) && problem5Input % 1 === 0 && problem5Input !== '') {
        var binaryInput = problem5Input.toString,
            thirdBit = (problem5Input >> 3) & 1;
        document.getElementById('pr5result').innerHTML =
            'Result: Binary representation of ' + problem5Input + ': ' + binaryNumber + '. Third bit: ' + thirdBit;
        console.log('Problem 5: Binary representation of ' + problem5Input + ': ' + binaryNumber + '. Third bit: ' + thirdBit);
    } else {
        document.getElementById('pr5result').innerHTML =
            'Input is not an integer!';
    }

    document.getElementById('problem5').value = '';
}

// Problem 6. Point in Circle

function problem6() {
    var coorX = document.getElementById('coor-x').value,
        coorY = document.getElementById('coor-y').value,
        r = 5,
        withinCircle = (coorX * coorX + coorY * coorY) <= r * r;

    if (!isNaN(coorX) && !isNaN(coorY) && coorX !== '' && coorY !== '') {
        document.getElementById('pr6result').innerHTML =
            'Result: Point (' + coorX + ',' + coorY + ') is within the circle K(O, 5). &#8594 ' + withinCircle;
        console.log('Problem 6: Point (' + coorX + ',' + coorY + ') is within the circle K(O, 5). &#8594 ' + withinCircle);
    } else {
        document.getElementById('pr6result').innerHTML =
            'X and Y must be numbers';
    }

    document.getElementById('coor-x').value = '';
    document.getElementById('coor-y').value = '';
}

// Problem 7. Is prime

function problem7() {
    var problem7Input = document.getElementById('problem7').value;
    var isPrime = true;

    if (!isNaN(problem7Input) && problem7Input % 1 === 0 && problem7Input !== '') {
        problem7Input *= 1;
        if (problem7Input < 2) {
            isPrime = false;
        } else {
            for (var i = 2; i <= Math.floor(Math.sqrt(problem7Input)); i += 1) {
                if (problem7Input % i === 0) {
                    isPrime = false;
                    break;
                }
            }
        }

        document.getElementById('pr7result').innerHTML =
            'Result: ' + problem7Input + ' is prime? &#8594 ' + isPrime;
        console.log('Problem 7: ' + problem7Input + ' is prime? &#8594 ' + isPrime);
        isPrime = false;
    } else {
        document.getElementById('pr7result').innerHTML = 'Input is not an integer!';
    }

    document.getElementById('problem7').value = '';
}

// Problem 8. Trapezoid area

function problem8() {
    var sideA = document.getElementById('side-a').value,
        sideB = document.getElementById('side-b').value,
        height = document.getElementById('height').value,
        area;

    if (!isNaN(sideA) && sideA > 0 && sideA !== '' && !isNaN(sideB) && sideB > 0 && sideB !== '' && !isNaN(height) && height > 0 && height !== '') {
        area = (sideA * 1 + sideB * 1) * height / 2;
        document.getElementById('pr8result').innerHTML =
            'Result: Trapezoid area is: (' + sideA + '+' + sideB + ')/2*' + height + '=' + area;
        console.log('Problem 8: Trapezoid area is: (' + sideA + '+' + sideB + ')/2*' + height + '=' + area);
    } else {
        document.getElementById('pr8result').innerHTML =
            'Side A, side B and height must be positive numbers!';
    }

    document.getElementById('side-a').value = '';
    document.getElementById('side-b').value = '';
    document.getElementById('height').value = '';
}

// Problem 9. Point in Circle and outside Rectangle

function problem9() {
    var coorX = document.getElementById('coord-x').value,
        coorY = document.getElementById('coord-y').value,
        r = 3,
        withinCircle = ((coorX - 1) * (coorX - 1) + (coorY - 1) * (coorY - 1)) <= r * r,
        outsideRect = ((coorX < -1) || (coorX > 5) || (coorY > 1) || (coorY < -1)),
        checkCondition = withinCircle && outsideRect;

    console.log(coorX);
    if (!isNaN(coorX) && !isNaN(coorY) && coorX !== '' && coorY !== '') {
        document.getElementById('pr9result').innerHTML =
            'Result: Point (' + coorX + ',' + coorY +
            ') is within the circle K((1,1)), 3) and outside the given rectangle &#8594 ' + checkCondition;
        console.log('Problem 9: Point (' + coorX + ',' + coorY +
            ') is within the circle K((1,1)), 3) and outside the given rectangle &#8594 ' + checkCondition);
    } else {
        document.getElementById('pr9result').innerHTML =
            'X and Y must be numbers';
    }

    document.getElementById('coord-x').value = '';
    document.getElementById('coord-y').value = '';
}

// Custom function for padding a string left with a total of 'num' characters 'ch'

String.prototype.padLeft = function(num, ch) {
    return Array(num - this.length + 1).join(ch || " ") + this;
};