function solve(){
    return function (books) {
        var authors = [],
            maxNumberOfBooks = 1;
        _.chain(books).map(function(item){
            item.author.fullName = item.author.firstName + ' ' + item.author.lastName;
            item.authorName = item.author.fullName;
            return item;
        }).sortBy('authorName').groupBy('authorName').each(function(value, key){
            authors.push([key, value.length]);
        })
        authors = _.chain(authors).sortBy(function(item){
            return item[0];
        }).sortBy(function(item){
            return -item[1];
        }).value();
        maxNumberOfBooks = authors[0][1];
        _.chain(authors).filter(function(item){
            return item[1] === maxNumberOfBooks;
        }).each(function(item){
            console.log(item[0]);
        });
    };
}

module.exports = solve;