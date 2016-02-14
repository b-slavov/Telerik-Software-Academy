function solve(){
    return function (animals) {
        var totalNumberOfLegs = 0;
        _.each(animals, function(item){
            totalNumberOfLegs += item.legsCount;
        });
        console.log('Total number of legs: ' + totalNumberOfLegs);
    };
}

module.exports = solve;