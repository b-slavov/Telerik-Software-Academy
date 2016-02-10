function solve(params){
    function getPoints(row, col){
        return (1 << row) - col;
    }
    function getRowsCols(str){
        var parts = str.split(' ');
        return [parseInt(parts[0]), parseInt(parts[1])];
    }
    function getValue(params, row, col){
        return params[row + 1][col];
    }
    var rowsCols = getRowsCols(params[0]),
        rows = rowsCols[0],
        cols = rowsCols[1],
        row = rows - 1,
        col = cols - 1,
        points = 0,
        moves = 0,
        used = [],
        move,
        horseMoves = [[-2, 1], [-1, 2], [1, 2], [2, 1], [2, -1], [1, -2], [-1, -2], [-2, -1]];
    while(1){
        if(row >= rows || col >= cols || row < 0 || col < 0){
            console.log('Go go Horsy! Collected ' + points + ' weeds');
            break;
        }
        if(used[row + ' ' + col]){
            console.log('Sadly the horse is doomed in ' + moves + ' jumps');
            break;
        }
        moves += 1;
        points += getPoints(row, col);
        move = horseMoves[getValue(params, row, col) - 1];
        used[row + ' ' + col] = true;
        row += move[0];
        col += move[1];
    }
}

// Tests:
console.log(solve(['3 5', '54561', '43328', '52388']));
console.log(solve(['3 5', '54361', '43326', '52188']));