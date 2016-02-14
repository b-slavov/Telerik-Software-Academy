function solve(){
    return function (students) {
        _.chain(students).filter(function(item){
            return item.firstName < item.lastName;
        }).map(function(item){
            item.fullName = item.firstName + ' ' + item.lastName;
            return item;
        }).sortBy('fullName')
            .reverse().each(function(item){
                console.log(item.fullName);
            });
    };
}

module.exports = solve;