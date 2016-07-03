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

function solve(args) {
    var options = JSON.parse(args[0]);
    var inputStr = args[1].replace(/'/, '"');

    String.prototype.bind = function (parameters) {
        var result = this;
        var currentMatch;
        
        regExAttr = new RegExp('data-bind-(.*?)="(.*?)"', 'gmi');

        while (currentMatch = regExAttr.exec(result)) {
            var arr;
            var index = result.indexOf('>');

            if (result[index - 1] === '/') {
                index--;
            }

            if (currentMatch[1] !== 'content') {
                arr = result.split('');
                arr.splice(index, 0, " " + currentMatch[1] + '="' + parameters[currentMatch[2]] + '"');
                result = arr.join('');
            } else {
                arr = result.split('');
                arr.splice(index + 1, 0, parameters[currentMatch[2]]);
                result = arr.join('');
            }
        }

        return result;
    };

    return inputStr.bind(options);
}