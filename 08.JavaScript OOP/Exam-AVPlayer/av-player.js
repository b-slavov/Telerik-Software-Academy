function solve() {
    // Array.prototype.findIndex() Polyfill
    if (!Array.prototype.findIndex) {
        Array.prototype.findIndex = function(predicate) {
            if (this == null) {
                throw new TypeError('Array.prototype.findIndex called on null or undefined');
            }
            if (typeof predicate !== 'function') {
                throw new TypeError('predicate must be a function');
            }
            var list = Object(this);
            var length = list.length >>> 0;
            var thisArg = arguments[1];
            var value;

            for (var i = 0; i < length; i++) {
                value = list[i];
                if (predicate.call(thisArg, value, i, list)) {
                    return i;
                }
            }
            return -1;
        };
    }

    function isValidString(str, minLength, maxLength) {
        return typeof(str) === 'string' && str.length >= minLength && str.length <= maxLength;
    }

    var player = function() {
        function byNameThenById(playlist1, playlist2) {
            if(playlist1.name === playlist2.name) {
                return playlist1.id - playlist2.id;
            }
            return playlist1.name.localeCompare(playlist2.name);
        }

        var player = {
                init: function (name) {
                    this.name = name;
                    this.playlists = [];
                    return this;
                },
                get name() {
                    return this._name;
                },
                set name(newName) {
                    if(!isValidString(newName, 3, 25)) {
                        throw {
                            name: 'InvalidPlayerNameError',
                            message: 'The player name, must be a string with length between 3 and 25 characters!'
                        };
                    }
                    this._name = newName;
                },
                addPlaylist: function (playlist) {
                    if(typeof(playlist.id) === 'undefined' || !playlist.name) {
                        throw {
                            name: 'InvalidPlayerError',
                            message: 'Cannot add player without id!'
                        }
                    };
                    this.playlists.push(playlist);
                    return this;
                },
                getPlaylistById: function (id) {
                    var i,
                        len;
                    for(i = 0, len = this.playlists.length; i < len; i += 1) {
                        if(this.playlists[i].id === id) {
                            return this.playlists[i];
                        }
                    }
                    return null;
                },
                removePlaylist: function (id) {
                    if(typeof(id) === 'undefined') {
                        throw {
                            name: 'InvalidIdError',
                            message: 'The provided id is not contained in the playlist!'
                        }
                    }
                    if(typeof(id) !== 'number') {
                        id = id.id;
                    }
                    var index = this.playlists.findIndex(function(playlist) {
                        return playlist.id === id;
                    });
                    if(index < 0) {
                        throw {
                            name: 'InvalidIdError',
                            message: 'The playlist does not contain an element with this id!'
                        }
                    }
                    this.playlists.splice(index, 1);
                    return this;
                },
                listPlaylists: function (page, size) {
                    if(typeof(page) === 'undefined' || typeof(size) === 'undefined' ||
                        page < 0 || size <= 0 || page * size > this.playlists.length) {
                        throw {
                            name: 'InvalidPageSizeError',
                            message: 'Page >= 0, Size >= 1 and Page * Size <= > count of playlists in player!'
                        };
                    }
                    this.playlists.sort(byNameThenById);
                    return this.playlists.slice(page * size, (page + 1) * size);
                },
                search: function(pattern) {
                    pattern = pattern.toLowerCase();
                    return this.playlists.filter(function(playlist) {
                        return playlist.getAllPlayables().some(function(playable) {
                            return playable.title.toLowerCase().indexOf(pattern) >= 0;
                        });
                    });
                }
            };
        return player;
    }();

    var playlist = function() {
        var lastId = 0,
            playlist = {
            init: function (name) {
                this.id = lastId += 1;
                this.name = name;
                this.playables = [];
                return this;
            },
            get name() {
                return this._name;
            },
            set name(newName) {
                if(!isValidString(newName, 3, 25)) {
                    throw {
                        name: 'InvalidPlaylistNameError',
                        message: 'The playlist name, must be a string with length between 3 and 25 characters!'
                    };
                }
                this._name = newName;
            },
            getAllPlayables: function() {
                return this.playables.slice();
            },
            addPlayable: function (playable) {
                if(typeof(playable.id) === 'undefined' || !playable.title) {
                    throw {
                        name: 'InvalidPlayableError',
                        message: 'Cannot add playable without id or title!'
                    }
                };
                this.playables.push(playable);
                return this;
            },
            getPlayableById: function (id) {
                var i,
                    len;
                for(i = 0, len = this.playables.length; i < len; i += 1) {
                    if(this.playables[i].id === id) {
                        return this.playables[i];
                    }
                }
                return null;
            },
            removePlayable: function (id) {
                if(typeof(id) === 'undefined') {
                    throw {
                        name: 'InvalidIdError',
                        message: 'The provided id is not contained in the playlist!'
                    }
                }
                if(typeof(id) !== 'number') {
                    id = id.id;
                }
                var index = this.playables.findIndex(function(playable) {
                    return playable.id === id;
                });
                if(index < 0) {
                    throw {
                        name: 'InvalidIdError',
                        message: 'The playlist does not contain an element with this id!'
                    }
                }
                this.playables.splice(index, 1);
                return this;
            },
            listPlayables: function (page, size) {
                if(typeof(page) === 'undefined' || typeof(size) === 'undefined' ||
                    page < 0 || size <= 0 || page * size > this.playables.length) {
                    throw {
                        name: 'InvalidPageSizeError',
                        message: 'Page >= 0, Size >= 1 and Page * Size <= > count of playlists in player!'
                    };
                }
                this.playables.sort(function(playable1, playable2) {
                    if(playable1.title === playable2.title) {
                        return playable1.id - playable2.id;
                    }
                    return playable1.title.localeCompare(playable2.title);
                });
                return this.playables.slice(page * size, (page + 1) * size);
            }
        };
        return playlist;
    }();

    var playable = function () {
        var lastId = 0,
            playable = {
                init: function (title, author) {
                    this.id = lastId += 1;
                    this.title = title;
                    this.author = author;
                    return this;
                },
                get title() {
                    return this._title;
                },
                set title(newTitle) {
                    if(!isValidString(newTitle, 3, 25)) {
                        throw {
                            name: 'InvalidTitleError',
                            message: 'Title must be a string with length between 3 and 25 characters!'
                        };
                    }
                    this._title = newTitle;
                },
                get author() {
                    return this._author;
                },
                set author(newAuthor) {
                    if(!isValidString(newAuthor, 3, 25)) {
                        throw {
                            name: 'InvalidAuthorError',
                            message: 'Author must be a string with length between 3 and 25 characters!'
                        };
                    }
                    this._author = newAuthor;
                },
                play: function () {
                    return this.id + '. ' + this.title + ' - ' + this.author;
                }
            };
        return playable;
    }();

    var audio = function(parent) {
        var audio = Object.create(parent);
        audio.init = function (title, author, length) {
            parent.init.call(this, title, author);
            this.length = length;
            return this;
        };
        audio.play = function () {
            return parent.play.call(this) + ' - ' + this.length;
        };
        Object.defineProperty(audio, 'length', {
            get: function() {
                return this._length;
            },
            set: function(newLength) {
                if(typeof(newLength) !== 'number' || newLength <= 0) {
                    throw {
                        name: 'AudioLengthError',
                        message: 'Audio length must be a number, greater than 0!'
                    }
                }
                this._length = newLength;
            }
        });
        return audio;
    }(playable);

    var video = function(parent) {
        var video = Object.create(parent);
        video.init = function (title, author, imdbRating) {
            parent.init.call(this, title, author);
            this.imdbRating = imdbRating;
            return this;
        };
        video.play = function () {
            return parent.play.call(this) + ' - ' + this.imdbRating;
        };
        Object.defineProperty(video, 'imdbRating', {
            get: function() {
                return this._imdbRating;
            },
            set: function(newImdbRating) {
                if(typeof(newImdbRating) !== 'number' || newImdbRating < 1 || newImdbRating > 5) {
                    throw {
                        name: 'VideoImdbRatingError',
                        message: 'Video ImdbRating must be a number, between 1 and 5!'
                    }
                }
                this._imdbRating = newImdbRating;
            }
        });
        return video;
    }(playable);

    var module = {
        getPlayer: function (name) {
            return Object.create(player).init(name);
        },
        getPlaylist: function (name) {
            return Object.create(playlist).init(name);
        },
        getAudio: function (title, author, length) {
            return Object.create(audio).init(title, author, length);
        },
        getVideo: function (title, author, imdbRating) {
            return Object.create(video).init(title, author, imdbRating);
        }
    };
    return module;
}

var module = solve();

var player = module.getPlayer('Pesho\'s player');

var playlist1 = module.getPlaylist('Furious chalga');
playlist1.addPlayable(module.getAudio('Elate pilenca pri batko', 'Milko Kalaydzhiev', 4.35))
        .addPlayable(module.getAudio('Karam si trabanta', 'Kosta Markov', 4.21));

var playlist2 = module.getPlaylist('Classic opera');
playlist2.addPlayable(module.getAudio('5th symphony', 'Bethoven', 4.35))
    .addPlayable(module.getAudio('blabla', 'Motzart', 4.21));

player.addPlaylist(playlist1);
console.log(player.listPlaylists(0, 100));
console.log(player.search('batko'));

player.addPlaylist(playlist2);
console.log(player.listPlaylists(0, 100));
console.log(player.search('blabla'));