function solve(params) {
    var rows = parseInt(params[0]),
        cols = parseInt(params[1]),
        tests = parseInt(params[rows + 2]),
        knightMoves = [[-2, 1], [-1, 2], [1, 2], [2, 1], [2, -1], [1, -2], [-1, -2], [-2, -1]];

    function getFigure(position) {
        var row = rows - position[1],
            col = position[0].charCodeAt(0) - 'a'.charCodeAt(0);
        return params[row + 2][col];
    }

    function solveTest(move) {
        var parts = move.split(' '),
            from = parts[0],
            to = parts[1],
            figure = getFigure(from);

        if (figure == '-') {
            return 'no'; // origin position is empty
        }

        if (getFigure(to) != '-') {
            return 'no'; // destination is not empty
        }

        if (figure == 'Q') {
            var minRow = Math.min(from[1], to[1]),
                maxRow = Math.max(from[1], to[1]),
                minCol = Math.min(from[0].charCodeAt(0), to[0].charCodeAt(0)),
                maxCol = Math.max(from[0].charCodeAt(0), to[0].charCodeAt(0)),
                figures = 0;
            if (from[0] == to[0]) { // same column
                // move through rows minRow-maxRow
                for (var i = minRow; i <= maxRow; i++) {
                    var newPos = from[0] + i;
                    if (getFigure(newPos) != '-') figures++;
                }
            }
            else if (from[1] == to[1]) { // same row
                // move through columns minCol-maxCol
                for (var i = minCol; i <= maxCol; i++) {
                    var newPos = String.fromCharCode(i) + from[1];
                    if (getFigure(newPos) != '-') figures++;
                }
            }
            else if (Math.abs(from[0].charCodeAt(0) - to[0].charCodeAt(0)) == Math.abs(from[1] - to[1])) { // diagonal
                if (from[0].charCodeAt(0) - to[0].charCodeAt(0) == from[1] - to[1]) {
                    // diagonal of type a1-c3
                    for (var i = 0; i <= maxRow - minRow; i++) {
                        var newPos = String.fromCharCode(minCol + i) + (minRow + i).toString();
                        if (getFigure(newPos) != '-') figures++;
                    }
                }
                else {
                    // diagonal of type a3-c1
                    for (var i = 0; i <= maxRow - minRow; i++) {
                        var newPos = String.fromCharCode(minCol + i) + (maxRow - i).toString();
                        if (getFigure(newPos) != '-') figures++;
                    }
                }
            }
            else {
                return 'no'; // invalid move for queen
            }

            if (figures != 1) {
                return 'no'; // more than one figure in the path
            }
        }
        else if (figure == 'K') {
            for (var i = 0; i < knightMoves.length; i++) {
                var knightMove = knightMoves[i];
                var newPos = String.fromCharCode(from[0].charCodeAt(0) + knightMove[1]) +
                    (parseInt(from[1]) + knightMove[0]).toString();
                if (newPos == to) {
                    return 'yes';
                }
            }
            return 'no';
        }
        else {
            return 'no'; // not a valid move for any of the given figures
        }

        return 'yes';
    }

    for (var i = 0; i < tests; i++) {
        var move = params[rows + 3 + i];
        var answer = solveTest(move);
        console.log(answer);
    }
}

/*solve([
 '3',
 '4',
 '--K-',
 'K--K',
 'Q--Q',
 '12',
 'd1 b3',
 'a1 a3',
 'c3 b2',
 'a1 c1',
 'a1 b2',
 'a1 c3',
 'a2 c1',
 'd2 b1',
 'b1 b2',
 'c3 a3',
 'a2 a3',
 'd1 d3'
 ]);
 console.log("----------------------------------------------------------");
 solve([
 '5',
 '5',
 'Q---Q',
 '-----',
 '-K---',
 '--K--',
 'Q---Q',
 '10',
 'a1 a1',
 'a1 d4',
 'e1 b4',
 'a5 d2',
 'e5 b2',
 'b3 d4',
 'b3 c1',
 'b3 d1',
 'c2 a3',
 'c2 b4'
 ]);*/