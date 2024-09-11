# ITI C# Tasks (.NET Web Development Track)

This repository contains various projects and tasks given as part of the ITI .NET web development track. Each project includes several tasks.

## Day 1

### Tasks
- **Task 1**: Write a program that receives a `number` and checks if it is positive or negative.
  
- **Task 2**: Write a program that receives a `number` and checks it is even or odd.
  
- **Task 3**: Write a program that receives the `length` and `width` and checks if they are the dimensions of a square or not.
  
## Day 2

### Tasks
- **Task 1**: Write a program that receives a number and then prints the multiplication table of that number.
  
- **Task 2**: Write a program that receives a `name`, `ID`, `age`, and `salary`.
  Ensure that the received `ID` and `age` are not negative numbers, and that the `salary` is not less than 0 and does not exceed 20,000. Then, print these information out.
  
- **Task 3**: Create a class named Student with the attributes `NAME`, `AGE`, `SSN`, and `SALARY`.
  Implement a `parameterized constructor` to initialize these attributes and a `print` method that prints the object's details (attribute values).
  Then, create an object of the class and use the `print` method.

## Day 3

### Tasks
- **Task 1**: Create a `Student` class with the attributes `ID`, `name`, and `age`.
  Implement 3 methods: `setData` to set the values of the attributes, `getData` to retrieve the values of the object's attributes, and `gotGraduated` to check if the person has graduated based on their age.
  If the age is equal to or above 24, the person has graduated; otherwise, they have not.
  Then, create 2 objects of the class and use all 3 methods.
  
- **Task 2**: Create a `Student` class with the attributes `ID`, `name`, and `age`.
  Implement `default`, `private`, `parameterized`, and `static constructors`.
  Ensure that the first time the class is used, it prints a welcoming message. Additionally, every time an object is created, print a message indicating that the object has been created.
  Create two methods, `GetData` and `gotGraduated`, which perform the same functions as in the previous task. Then, create different objects to practice the constructors and methods you just created.
 
- **Task 3**: Create a `Book` class with the attributes `ID`, `bookName`, `releaseDate`, `price`, `isDeleted`, and `count`.
  Implement different types of `parameterized constructors` as well as a `default constructor`. Ensure that a welcoming message appears the first time the class is used.
  The count attribute should track the number of Book objects created, and print the number of books each time a new object is created.
  Implement the following methods: `howManyBooks` to return the number of books. `getBookData` to print the information of a book. `delete` to change the isDeleted attribute state when called.
  Make sure to create different objects to practice using these various constructors and methods.

## Day 4

### Tasks
- **Task 1**: Write a program that receives the `number of students` and then receives the `students' names` and `ages`, using `arrays`.
  Then display the data of the specific student when the user enters their `id` (An index of the array represent an `id`).
  
- **Task 2**: Write a program that receives an `array of numbers as a string` in a specific format, then extracts the numbers from that string.
  Create a second array where each element in it is `the product of all elements except for the one at that index`.
  Print the elements of the second array.
  
## Day 5

### Task
- Create an `HTMLElement` class with `type` and `value` attributes, along with `constructors`, `getters`, `setters`, a `render` method to print element info, and a `ToString` method to return the element info.
  Then, create `ImageElement` and `TextElement` classes that inherit from `HTMLElement`.
  The `ImageElement` class should have an additional `src` attribute, `constructors`, `getters`, `setters`, `render`, and `ToString` methods.
  The `TextElement` class should have additional `fontColor` and `fontSize` attributes, `constructors`, `getters`, `setters`, `render`, and `ToString` methods.
  Create `H1Element` and `H2Element` classes that inherit from `TextElement`. Implement `constructors`, `getters`, `setters`, `render`, and `ToString` methods for these classes.
  Finally, create objects of these different HTML elements, add them all to a `List`, and print the contents of that list.

## Day 7

### Tasks
- Tasks are in `Day07.pdf` file, inside `Day7` folder.
  
