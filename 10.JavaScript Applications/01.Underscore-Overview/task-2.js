function solve(){
    return function (students) {
        _.chain(students).map(function(item){
            item.fullName = item.firstName + ' ' + item.lastName;
            return item;
        }).filter(function(item){
            return 18 <= item.age && item.age <= 24;
        }).sortBy('fullName')
            .each(function(item){
                console.log(item.fullName);
            })
    };
}

module.exports = solve;