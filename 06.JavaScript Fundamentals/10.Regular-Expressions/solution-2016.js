// Problem 1. Format with placeholders

function solve(args) {
    String.prototype.format = function (options) {
        var prop,
            result = this;

        for (prop in options) {
            result = result.replace(new RegExp('#{' + prop + '}', 'g'), options[prop]);
        }

        return result;
    };

    console.log(args[1].format(JSON.parse(args[0])));
}

// Problem 2. HTML binding

