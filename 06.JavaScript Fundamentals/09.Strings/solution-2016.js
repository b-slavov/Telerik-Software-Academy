// Problem 1. Reverse string

function solve(args) {
    return args[0].split('').reverse().join('');
}

// Problem 2. Correct brackets

function solve(args) {
    var expression = args[0],
        i,
        len = expression.length,
        leftBrackets = 0,
        rightBrackets = 0;

    for (i = 0; i < len; i += 1) {
        if (expression[i] === '(') {
            leftBrackets += 1;
        } else if (expression[i] === ')') {
            rightBrackets += 1;
        }

        if (leftBrackets < rightBrackets) {
            return 'Incorrect';
        }
    }

    if (leftBrackets === rightBrackets) {
        return 'Correct';
    }

    return 'Incorrect';
}

// Problem 3. Sub-string in text

function solve(args) {
    var word = args[0].toLowerCase(),
        text = args[1].toLowerCase(),
        i,
        count = 0,
        textLength = text.length,
        wordLength = word.length;

    for (i = 0; i < textLength - wordLength + 1; i += 1) {
        if (text.substr(i, wordLength) === word) {
            count += 1;
        }
    }

    console.log(count);
}

// Problem 4. Parse tags

function solve(args) {
    var text = args[0];

    text = text.replace(/<upcase>(.*?)<\/upcase>/g, function (a, l) { return l.toUpperCase(); });
    text = text.replace(/<lowcase>(.*?)<\/lowcase>/g, function (a, l) { return l.toLowerCase(); });
    text = text.replace(/<orgcase>(.*?)<\/orgcase>/g, '$1');

    console.log(text);
}

// Problem 5. nbsp

function solve(args) {
    return (args[0].split(' ').join('&nbsp;'));
}

// Problem 6. Extract text from HTML

function solve(args) {
    var pattern = /<.*?>/ig,
        output = '',
        line;

    for (line of args) {
        output += line.replace(pattern, '').trim();
    }

    console.log(output);
}

// Problem 7. Parse URL

function solve(args) {
    var url = args[0].split('://'),
        protocol = url[0],
        server,
        resource;

    url = url[1].split('/');
    server = url.shift();
    resource = url.join('/');

    console.log('protocol: ' + protocol);
    console.log('server: ' + server);
    console.log('resource: /' + resource);
}

// Problem 8. Replace tags

function solve(args) {
    console.log(args[0].replace(/<a href="(.*?)">(.*?)<\/a>/g, '[$2]($1)'));
}
