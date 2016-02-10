// Problem 1. Make person

console.log('Problem 1:');

var people = createPeople();
people.forEach(function(item) {
    console.log(item);
});

function createPerson(fname, lname, age, gender) {
    return {
        firstname: fname,
        lastname: lname,
        age: age,
        gender: gender
    };
}

function createPeople() {
    var i,
        firstNames = ['Novak', 'Andy', 'Roger', 'Stanislas', 'Rafael', 'Serena', 'Angelique', 'Simona', 'Angnieszka', 'Maria'],
        lastNames = ['Djokovic', 'Murrey', 'Federer', 'Wawrinka', 'Nadal', 'Williams', 'Kerber', 'Halper', 'Radwanska', 'Sharapova'],
        arr = [];
    for (i = 0; i < 10; i += 1) {
        arr[i] = createPerson(firstNames[i], lastNames[i], ((Math.random() * 20) + 10) | 0, (i > 4));
    }
    return arr;
}

// Problem 2. People of age

console.log('Problem 2:');

var ofAgeOnly =
    people.every(function(item) {
        return item.age >= 18;
    });
console.log(ofAgeOnly);

// Problem 3. Underage people

console.log('Problem 3:');

var underaged =
    people.filter(function(item) {
        return item.age < 18;
    }).forEach(function(item) {
        console.log(item);
    });

// Problem 4. Average age of females

console.log('Problem 4:');

var femaleSum =
    people.filter(function(item) {
        return item.gender;
    }).reduce(function(sum, item, i, arr) {
        var count = arr.length;
        return (sum + item.age / count);
    }, 0);

var roundedAge = femaleSum.toFixed(1);
console.log(roundedAge);

// Problem 5. Youngest person

console.log('Problem 5:');

if (!Array.prototype.find) {
    Array.prototype.find = function(callback) {
        var i, len = this.length;
        for (i = 0; i < len; i += 1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }
    };
}

var youngestMale =
    people.sort(function(a, b) {
        return a.age - b.age;
    }).find(function(item) {
        return !item.gender;
    });

console.log(youngestMale.firstname, youngestMale.lastname);

// Problem 6. Group people

console.log('Problem 6:');

var result = people.reduce(function(obj, item) {
    if (obj[item.firstname[0]]) {
        obj[item.firstname[0]].push(item);
    } else {
        obj[item.firstname[0]] = [item];
    }
    return obj;
}, {});

console.log(result);