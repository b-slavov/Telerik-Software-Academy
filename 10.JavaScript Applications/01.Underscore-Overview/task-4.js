function solve(){
    return function (animals) {
        var groupedBySpeciesDescending = _.chain(animals).sortBy('species').reverse().groupBy('species').value();

        _.each(groupedBySpeciesDescending, function(value, key){
            value = _.chain(value).sortBy('legsCount').sortBy(value, 'name').value();
            console.log(Array(key.length + 2).join('-'));
            console.log(key + ':');
            console.log(Array(key.length + 2).join('-'));
            for(var i = 0, len = value.length; i < len; i += 1){
                console.log(value[i].name + ' has ' + value[i].legsCount + ' legs');
            }
        });
    };
}

module.exports = solve;