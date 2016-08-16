function solve() {
    return function (selector, isCaseSensitive) {
        root = document.querySelector(selector);

        var wrapper = document.createElement('div');
        wrapper.className = 'items-control';

        var addDiv = document.createElement('div');
        addDiv.className = 'add-controls';

        var addText = document.createElement('label');
        addText.innerHTML = 'Enter text';

        var addInput = document.createElement('input');
        addText.appendChild(addInput);

        addDiv.appendChild(addText);

        var addButton = document.createElement('button');
        addButton.className = 'button';
        addButton.innerHTML = 'Add';
        addButton.style.textDecoration = 'none';
        addButton.style.display = 'inline-block';
        addButton.style.cursor = 'pointer';

        addDiv.appendChild(addButton);

        var searchDiv = document.createElement('div');
        searchDiv.className = 'search-controls';

        var searchText = document.createElement('label');
        searchText.innerHTML = 'Search';

        var searchInput = document.createElement('input');
        searchText.appendChild(searchInput);

        searchDiv.appendChild(searchText);

        var resultDiv = document.createElement('div');
        resultDiv.className = 'result-controls';

        var resultUl = document.createElement('ul');
        resultUl.className = 'items-list';

        var resultLi = document.createElement('li');
        resultLi.className = 'list-item';

        var liButton = document.createElement('button');
        liButton.className = 'button';
        liButton.innerHTML = 'X';
        liButton.style.textDecoration = 'none';
        liButton.style.cursor = 'pointer';

        var liText = document.createElement('strong');

        resultDiv.appendChild(resultUl);

        addButton.addEventListener('click', function () {
            liText.innerHTML = addInput.value;
            resultLi.appendChild(liText);
            resultLi.appendChild(liButton);
            addInput.value = '';
            resultUl.appendChild(resultLi.cloneNode(true));
        }, false)

        resultUl.addEventListener('click', function (event) {
            if (event.target.className === 'button') {
                resultUl.removeChild(event.target.parentNode);
            }
        }, false);

        addInput.addEventListener('keydown', function (ev) {
            if (ev.keyCode === 13) {
                liText.innerHTML = addInput.value;
                resultLi.appendChild(liText);
                resultLi.appendChild(liButton);
                addInput.value = '';
                resultUl.appendChild(resultLi.cloneNode(true));
            }
        }, false);

        var allLi = document.getElementsByClassName('list-item');

        searchInput.addEventListener('input', function () {
            var inputedValue = searchInput.value;
            var textInsideLI;
            for (var i = 0; i < allLi.length; i += 1) {
                textInsideLI = allLi[i].getElementsByTagName('strong')[0].innerHTML;

                if (!isCaseSensitive) {
                    textInsideLI = textInsideLI.toLowerCase();
                    inputedValue = inputedValue.toLowerCase();
                }

                if (textInsideLI.indexOf(inputedValue) === -1) {
                    allLi[i].style.display = 'none';
                }
                else {
                    allLi[i].style.display = '';
                }
            }
        });

        wrapper.appendChild(addDiv);
        wrapper.appendChild(searchDiv);
        wrapper.appendChild(resultDiv);

        root.appendChild(wrapper);
    };
}

module.exports = solve;
