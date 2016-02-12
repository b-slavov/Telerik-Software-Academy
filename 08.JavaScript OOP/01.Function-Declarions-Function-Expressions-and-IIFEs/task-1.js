function solve() {
    return function sumArrayOfNumbers(array) {
        if (!array.every(function(item) {
                return !isNaN(item);
            })) {
            throw 'Numbers must be always of type Number!';
        }
        if (array.length === 0) {
            return null;
        }
        if (!array) {
            throw 'Parameter is not passed!';
        }
        return array.reduce(function (a, b) {
            return parseInt(a) + parseInt(b)
        });
    }
}