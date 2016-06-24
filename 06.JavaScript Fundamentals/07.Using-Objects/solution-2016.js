// Problem 1. Planar coordinates

function solve(args) {
    var input = args.map(Number),
        x1 = input[0],
        y1 = input[1],
        x2 = input[2],
        y2 = input[3],
        segment1,
        x3 = input[4],
        y3 = input[5],
        x4 = input[6],
        y4 = input[7],
        segment2,
        x5 = input[8],
        y5 = input[9],
        x6 = input[10],
        y6 = input[11],
        segment3;

    p1 = createPoint(x1, y1);
    p2 = createPoint(x2, y2);
    p3 = createPoint(x3, y3);
    p4 = createPoint(x4, y4);
    p5 = createPoint(x5, y5);
    p6 = createPoint(x6, y6);

    if (calculateDistance(p1, p2) > 0) {
        segment1 = createSegment(p1, p2);
        console.log(segment1.length.toFixed(2));
    }

    if (calculateDistance(p3, p4) > 0) {
        segment2 = createSegment(p3, p4);
        console.log(segment2.length.toFixed(2));
    }

    if (calculateDistance(p5, p6) > 0) {
        segment3 = createSegment(p5, p6);
        console.log(segment3.length.toFixed(2));
    }

    if (canFormTriangle(segment1, segment2, segment3)) {
        console.log('Triangle can be built');
    } else {
        console.log('Triangle can not be built');
    }

    function createPoint(x, y) {
        return {
            'x': x,
            'y': y
        };
    }

    function createSegment(point1, point2) {
        return {
            'p1': point1,
            'p2': point2,
            'length': calculateDistance(point1, point2)
        };
    }

    function calculateDistance(point1, point2) {
        return Math.sqrt((point1.x - point2.x) * (point1.x - point2.x) + (point1.y - point2.y) * (point1.y - point2.y));
    }

    function canFormTriangle(sideA, sideB, sideC) {
        if ((sideA.length + sideB.length > sideC.length) &&
            (sideA.length + sideC.length > sideB.length) &&
            (sideB.length + sideC.length > sideA.length)) {
            return true;
        } else {
            return false;
        }
    }
}

// Problem 2. Remove elements

function solve(args) {
    Array.prototype.remove = function (value) {
        while (this.indexOf(value) >= 0) {
            this.splice(this.indexOf(value), 1);
        }

        return this;
    };

    var item = args[0];

    return args.remove(item).join('\n');
}

// Problem 5. Youngest person

function solve(args) {
    var people = new Array(args.length / 3),
        i,
        j,
        youngestPerson;

    for (i = 0, j = 0; i < args.length; i += 3, j++) {
        people[j] = createPerson(args[i], args[i + 1], +args[i + 2]);
    }

    youngestPerson = people[0];
    for (i = 1; i < people.length; i++) {
        if (youngestPerson.age > people[i].age) {
            youngestPerson = people[i];
        }
    }

    return youngestPerson.firstName + ' ' + youngestPerson.lastName;

    function createPerson(firstName, lastName, age) {
        return {
            'firstName': firstName,
            'lastName': lastName,
            'age': age
        };
    }
}
