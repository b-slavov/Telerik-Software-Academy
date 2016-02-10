function solve(params) {
    var s = params[0].split(' ').map(Number),
        i,
        currentRocks = 1,
        maxRocks = 2;

    for (i = 1; i <= s.length - 2; i += 1) {
        if(!(s[i] >= s[i - 1] && s[i] >= s[i + 1])) {
            currentRocks += 1;
            if(s[i] === s[s.length - 2] && currentRocks > maxRocks){
                maxRocks = currentRocks;
            }
        } else {
            if(currentRocks > maxRocks) {
                maxRocks = currentRocks;
            }
            currentRocks = 1;
        }
    }
    console.log(maxRocks);
}

// Tests:
console.log(solve(['5 1 7 4 8'])); // Output -> 2
console.log(solve(['5 1 7 6 3 6 4 2 3 8'])); // Output -> 4
console.log(solve(['10 1 2 3 4 5 4 3 2 1 10'])); // Output -> 5