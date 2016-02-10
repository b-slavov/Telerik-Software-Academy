//Problem 1. JavaScript literals

var intLit = 1,
    floatLit = 2.01,
    boolLit = true,
    stringLit = "This is string.",
    objectLit = {
        name: 'Pesho',
        age: 70
    },
    arrayLit = [1, 2, 3],
    functionLit = function() {
        alert('This is function.');
    };

//Problem 2. Quoted text

var quotedString = '"How you doin\'?", Joey said.',
    newDiv = document.createElement('div');

newDiv.innerHTML = quotedString;
document.getElementById('problem2').appendChild(newDiv);
console.log('Problem 2. Quoted text: ' + quotedString);

//Problem 3. Typeof variables

var arrayOfVariables = [
    intLit,
    floatLit,
    boolLit,
    stringLit,
    objectLit,
    arrayLit,
    functionLit,
    quotedString
];

console.log('Problem 3. Typeof variables \n');

for (var i = 0; i < arrayOfVariables.length - 1; i += 1) {
    getTypeOf(arrayOfVariables[i], "problem3");
    console.log('Type of ' + arrayOfVariables[i] + ' is: ' + typeof(arrayOfVariables[i]));
}

//Problem 4. Typeof null

console.log('Problem 4. Typeof null \n');

var nullVar = null,
    undefinedVar; // undefined

console.log('Type of ' + nullVar + ' is: ' + typeof(nullVar));
console.log('Type of ' + undefinedVar + ' is: ' + typeof(undefinedVar));

getTypeOf(nullVar, "problem4");
getTypeOf(undefinedVar, "problem4");

//Visualize

function getTypeOf(obj, taskNumberId) {
    var currDiv = document.createElement('div');
    var result = 'The type of ' + obj + ' is ' + '<span style="color:red">' + typeof(obj) + '</span>';
    currDiv.innerHTML = result + ' ';
    document.getElementById(taskNumberId).appendChild(currDiv);
}

var divs = document.getElementsByTagName("div"),
    container = document.getElementById("container");

for (var i = 0; i < divs.length; i += 1) {
    divs[i].style.border = "1px solid black";
    divs[i].style.padding = "10px";
    divs[i].style.width = "96%";
}