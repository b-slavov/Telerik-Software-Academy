function solve() {
    var Person = (function () {
        function isValidName(value) {
            var regex = /^[a-z]{3,20}$/gi;

            return regex.test(value);
        }

        function isValidAge(value) {
            var age = parseInt(value, 10);

            return age >= 0 && age <= 150;
        }

        function Person(firstname, lastname, age) {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        Object.defineProperty(Person.prototype, 'firstname', {
            get: function () {
                return this._firstname;
            },
            set: function (value) {
                if (!isValidName(value)) {
                    throw Error('Invalid firstname! The firstname should be a string with only Latin letters between 3 and 20 characters!')
                }

                this._firstname = value;
            }
        });

        Object.defineProperty(Person.prototype, 'lastname', {
            get: function () {
                return this._lastname;
            },
            set: function (value) {
                if (!isValidName(value)) {
                    throw Error('Invalid lastname! The lastname should be a string with only Latin letters between 3 and 20 characters!')
                }

                this._lastname = value;
            }
        });

        Object.defineProperty(Person.prototype, 'age', {
            get: function () {
                return this._age;
            },
            set: function (value) {
                if (!isValidAge(value)) {
                    throw Error('Invalid age! The age should be a number between 0 and 150!')
                }

                this._age = parseInt(value, 10);
            }
        });

        Object.defineProperty(Person.prototype, 'fullname', {
            get: function () {
                return this._firstname + ' ' + this._lastname;
            },
            set: function (value) {
                var names = value.split(' ');

                this.firstname = names[0];
                this.lastname = names[1];
            }
        });

        Person.prototype.introduce = function () {
            return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old.';
        };

        return Person;
    }());
    return Person;
}
module.exports = solve;