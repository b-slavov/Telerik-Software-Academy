#Task 1: ImagesPreviewer

* Given the HTML `index.html` write JavaScript function `createImagesPreviewer(selector, items)` in file `scripts.js`

  * The function accepts two parameters:
    * **Selector**
      * The selector of the DOM element, where the previewer must be generated in
      * It can be any CSS3 selector (`#id`, `.class`, `NODE_NAME`)
    * **Items** 
      * An array of objects
      * Every object in the array has two mandatory properties:
        * **title** - the title of the image
        * **url** - a path to the image (JPG/PNG)
        
  * The execution of the `createImagesPreviewer(selector, items)` function should result as follows:
    * All images from the items collection must be displayed on the right
      * With their title above them
    * Above the images on the right, there must be a filter box
      * For filtering images
    * The first item from the items collection should be displayed bigger on the left
      * With its title on top
    * _Example_:
      ![] (https://github.com/b-slavov/Telerik-Software-Academy/blob/master/09.JavaScript%20DOM%20%26%20UI/Exam-17-Jun-2014/Descriptions/task-1-result/1.%20initial.png)      
      
  * Images in the list (on the right) have some properties:
    * The title and the image must have a parent with class `image-container`
    * When `hovered`
      * They should change their **background color**      
      * _Example:_      
        ![] (https://github.com/b-slavov/Telerik-Software-Academy/blob/master/09.JavaScript%20DOM%20%26%20UI/Exam-17-Jun-2014/Descriptions/task-1-result/2.%20cow-hovered.png)
    * When `unhovered`
      * They should return to their **default background color**
    * When `clicked`
      * The **bigger image and its title** (on the left) are **replaced with the clicked image on the left**
      * _Example:_      
        ![] (https://github.com/b-slavov/Telerik-Software-Academy/blob/master/09.JavaScript%20DOM%20%26%20UI/Exam-17-Jun-2014/Descriptions/task-1-result/3.%20hamster-clicked.png)
  * The big image and title on the left must have a parent with class `image-preview`
      
  * The filter should provide functionality for **filtering the images** on the list of images (on the right)
    * When the text in the box changes
      * The list of images should be filtered only to those that have a title containing the pattern
      * The pattern matching is case-insensitive
    * When the text in the box is empty
      * All images should be visible
    * _Example:_      
      ![] (https://github.com/b-slavov/Telerik-Software-Academy/blob/master/09.JavaScript%20DOM%20%26%20UI/Exam-17-Jun-2014/Descriptions/task-1-result/4.%20text-in-filter.png)
      
  * Constraints:
    * You are allowed only to edit the contents of the file "scripts.js"
    * You are NOT allowed to edit the contents of the HTML and/or the CSS files    