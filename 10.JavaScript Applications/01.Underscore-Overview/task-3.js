function solve(){
    return function (students) {
        var student = _.chain(students).map(function(item){
            item.fullName = item.firstName + ' ' + item.lastName;
            var sum = 0,
                i,
                len;
            for(i = 0, len = item.marks.length; i < len; i += 1){
                sum += item.marks[i];
            }

            item.averageMark = sum/len;
            return item;
        }).sortBy('averageMark').last().value();
        console.log(student.fullName + ' has an average score of ' + student.averageMark);
    };
}

module.exports = solve;