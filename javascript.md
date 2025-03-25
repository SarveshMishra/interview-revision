<details>
  <summary>What is hoisting?</summary>
  
<p>
Hoisting is the JavaScript behavior of moving all declarations to the top of the current scope. This means that all variables and functions are available before they are declared. This is useful for code that is used in multiple places, but is not used until it is declared. For example, the following code: 
</p>

```js
foo();
console.log(b); // 2
console.log(a); // undefined
function foo() {
	var a = (b = 2);
	console.log(b); // 2
	console.log(a); // 2
}
```

</details>

<details>
  <summary>What is scoping?</summary>

<p>
Scoping is the process of binding a variable to a specific scope. Basically there are three type of scope in JavaScript, Global Scope, Local or Functional Scope and Block Scope. If we don't put any keyword like var, let or const that means it is a global scope. If we put var then that variable is in functional scope. If we put let then that variable is in block scope and const is for constant or immutable variable.
</p>

</details>
<details>
  <summary>How are var, let const different?</summary>

<p>
var is a global variable, let is a block scope variable, and const is a constant variable.
</p>

</details>
<details>
  <summary>What are the two main differences in arrow functions?</summary>

<p>
The first is that arrow functions do not have their own this keyword, they use the this keyword of the enclosing scope. For example, if we have method in an object and some variable can't be access with this keyword but in regular function we can use this keyword. For example,

</p>

```js
let test = {
	a: 1,

	test1: () => {
		console.log(this.a);
	},
	test2() {
		console.log(this.a);
	},
};
test.test1(); // undefined
test.test2(); // 1
```

<p>
The second is that arrow functions do not have their own arguments keyword, they use the arguments keyword of the enclosing scope.
</p>

```js
let test = {
	test1: () => {
		console.log(arguments);
	},
};
let anotherTest = {
	test2() {
		console.log(arguments);
	},
};
test.test1(1, 2, 3); //VM70:3 Uncaught ReferenceError: arguments is not defined
// at Object.test1 (<anonymous>:3:15)
// at <anonymous>:1:6
anotherTest.test2(1, 2, 3);
```

</details>
<details>
  <summary>Does Call apply bind work for arrow functions?</summary>

<p>
Yes, it does.
</p>

</details>
<details>
  <summary>What does call apply bind do?</summary>
    
<p> Call applies the function to the this keyword of the calling object. It provides new value to this keyword</p>

```js
let fooBar = {
	name: 'fooBar',
	foo: function () {
		console.log(this);
	},
};

const fooBar2 = {
	name: 'fooBar2',
};

fooBar.foo.call(fooBar2); // {name: 'fooBar2', foo: ƒ}
```

<p> Bind binds the function to the this keyword of the object it is called on.</p>

```js
// bind

let foo = (a, b) => {
	return a + b;
};

let bar = foo.bind(this, 1);

console.log(bar(2)); // 3
```

<p> Apply applies the function to the arguments of the calling object.</p>

![](Screenshot%20from%202022-05-13%2000-01-45.png)

<strong>All Call, Apply and Bind do the exact same thing. The only difference is Apply takes only one argument as an array while bind doesnt executes itself right away, it just binds the new 'this' value.</strong>

</details>
<details>
  <summary> Write a program to debounce a search bar?</summary>

<p>
The debounce function is a function that delays the execution of a callback function.</p>

```js
let timeout;
const debounce = (cbFunc, wait) => {
	if (timeout) {
		clearTimeout(timeout);
	}
	timeout = setTimeout(() => {
		cbFunc();
	}, wait);
};
```

</details>
<details>
  <summary>Write a program to throttle a search bar?</summary>

<p>
The throttle function is a function that limits the number of times a callback function can be called.
</p>

```js
let pauseTime;

const throttle = (cbFunc, wait) => {
	if (pauseTime) {
		return;
	}
	pauseTime = true;
	setTimeout(() => {
		cbFunc();
		pauseTime = false;
	}, wait);
};
```

</details>
<details>
  <summary>create a custom method for an array called myMap, use prototype chain to achieve this</summary>

```js

Array.prototype.myMap = function (cb) {
	const res = [];
	for (let i = 0; i < this.length; i++) {
		res.push(cb(this[i]));
	}
	return res;
};
arr = [1, 2, 3];
console.log(arr.myMap((a) => a * 5));
```
</details>
<details>
  <summary>What is event bubbling?</summary>

<p>
Event bubbling is the behavior in which an event bubbles up through the DOM until it reaches the root of the document.
</p>

</details>
<details>
  <summary>What is event loop?</summary>

<p>
The event loop is the process of processing events in the browser. It is the main loop of the browser. It is responsible for updating the DOM and calling the event handlers. It contains two main parts: the event queue and the call stack. The event queue is a list of events that are waiting to be processed. The call stack is a list of functions that are currently being executed. When browsers encounter any event, which will run in future, it will be added to the event queue and proceed next event. After that when every synchronous event is processed, the event loop will start getting the next event from the event queue.
</p>

</details>
<details>
  <summary>Explain promises to a 5 year old, with simple examples</summary>

<p>
Promise in programming is same real world promise. For example, if you go to school without crying then I promise I'll buy you bicycle. So here I am promising for future that I will buy you bicycle only if you go to school without crying.
</p>

</details>
<details>
  <summary>Write a function called sleep that will return a promise, if you do not provide a number to the function, then it will return an error and goto the catch block</summary>

```js

let sleep = (time) =>
	new Promise(function (resolve, reject) {
		if (time) {
			resolve(time);
		} else {
			reject(new Error('Time is not defined'));
		}
	});

sleep(500)
	.then((res) => {
		console.log(`slept for ${res} mil seconds`);
	})
	.catch((error) => {
		console.log(error);
	});

```

</details>
<details>
  <summary>what does async await mean?</summary>

<p>
Async await is a way to handle asynchronous code. It is a way to handle code that is not synchronous. With async await we can wait for a promise to resolve before continuing.
</p>

</details>
<details>
  <summary>What does the this keyword mean?</summary>

<p>
The this keyword refers to the object that is currently executing the function. It is used to access the properties and methods of the object. It points to the owner object.
</p>

```js
this keyword

// console.log(this); // Window

function foo() {
	console.log(this); // Window
}
foo();

let fooBar = {
	name: 'fooBar',
	foo: function () {
		console.log(this); // {name: 'fooBar', foo: ƒ}
	},
};
// fooBar.foo();
```

</details>
<details>
  <summary>What are classes? what are getters and setters?</summary>

<p>
Classes are a way to create objects. They are a way to create objects that have properties and methods.
</p>
<p>
Getters and setters are a way to create properties that can only be accessed by the object itself.
</p>

</details>
<details>
  <summary>How do you declare private and static variables in classes</summary>

<p>
Private variables are variables that are only accessible within the class. Static variables are variables that are accessible outside the class.
</p>

</details>
<details>
  <summary>Create a Calculator class, it should be able to add, reduce multiply and divide. it should have a value getter, and that should return final output. keep the history of changes made as well, and keep that private, and a user should be able to see previous changes made to the value</summary>

</details>
<details>
  <summary>What is currying?</summary>

<p>
Currying is a way to transform a function that takes multiple arguments into a function that takes a single argument.
</p>

```js
function curry(f) { // curry(f) does the currying transform
  return function(a) {
    return function(b) {
      return f(a, b);
    };
  };
}

// usage
function sum(a, b) {
  return a + b;
}

let curriedSum = curry(sum);

alert( curriedSum(1)(2) ); // 3	****
```

</details>
<details>
  <summary>Write a program to flatten an array</summary>

```js

// Flatten an array

let arr = [1, [2, 3], [3], [[[5]], 6]];
// output => [ 1, 2, 3, 3, 5, 6 ]

// Methods 1
let res = [].concat(...arr); // for single depth
let flatArray = [].concat.apply([], arr); // for single depth
console.log(res);
console.log(arr.flat(Infinity)); // for multiple depth

// Doing recursive
let res = [];
const recur = (arr) => {
	for (let i = 0; i < arr.length; i++) {
		if (Array.isArray(arr[i])) {
			recur(arr[i]);
		} else {
			res.push(arr[i]);
		}
	}
}
recur(arr);
console.log(res);


```

</details>
	
<details>
<summary>
Give an example where call apply bind is. required?
</summary>

<p>

</details>
<details>
<summary>
What is the difference between readFile and readFileSync?

</summary>

<p>ReadFile is asynchronous and readFileSync is synchronous. The first one stores the data in a buffer and the second one returns the data as a string. 
</p>

```js
console.log('File Reading Started from readFile');
fs.readFile('hello.txt', 'utf8', (err, data) => {
	if (err) {
		console.log(err);
	} else {
		console.log(data);
	}
});
console.log('File Reading Ended from readFile');    

console.log('File Reading Started from readFileSync');
const content = fs.readFileSync('hello.txt', 'utf8');
console.log(content);
console.log('File Reading Ended from readFileSync');

```

</details>
<details>
<summary>
What does process in node.js mean?
</summary>

<p>
process is an object that represents the current node.js process. It has a property called argv which is an array of the command line arguments. It also has a property called env which is an object containing the environment variables.

</p>
</details>
<details>
<summary>
Explain what node.js is?

</summary>

<p>
Node.js is a platform built on Chrome's JavaScript runtime for easily building fast, scalable network applications. Node.js uses an event-driven, non-blocking I/O model that makes it lightweight and efficient, perfect for data-intensive real-time applications that run across distributed devices. Node js is a single-threaded JavaScript runtime that executes instructions asynchronously in a non-blocking manner.
</p>

</details>

<details>
<summary>
What is the difference of JS from browser to JS on node.js
</summary>

<p>
Unlike browser, node.js support file read and write. In browser it is secure environment. In node.js it give full control over the environment in which the code is running.
</p>
</details>
<details>
<summary>
Write three different ways to reverse a string in Javascript? a. using inbuilt method, b. iteratively, c. recursively

</summary>

```js
const str = "sarvesh"

// Built-in reverse function
const reverseString = str.split('').reverse().join('')
console.log(reverseString)


// Reverse a string using recursion
const recur = (str) => {
    if (str === '') {
        return '';
    }
    return recur(str.substr(1)) + str.charAt(0);
}
console.log(recur(str))

// Reverse a string using for loop
const loopMethod = (str) => {
    let reversed = '';
    for (let character of str) {
        reversed = character + reversed;
    }
    return reversed;
}
```

</details>
<details>
<summary>
Write a program to check two objects are equal ( deep equal )
</summary>

```js
function isObjectEqual(a, b) {
	const flattenObj = (object, result = {}) => {
		for (const i in object) {
			if (typeof object[i] === 'object' && !Array.isArray(object[i])) {
				const temp = flattenObj(object[i]);
				for (const j in temp) {
					result[`${i}.${j}`] = temp[j];
				}
			} else {
				result[i] = object[i];
			}
		}
		return result;
	};
	const aFlat = flattenObj(a);
	const bFlat = flattenObj(b);
	// Create arrays of property names
	const aProps = Object.getOwnPropertyNames(aFlat);
	const bProps = Object.getOwnPropertyNames(bFlat);

	// If their property lengths are different, they're different objects
	if (aProps.length !== bProps.length) {
		return false;
	}

	for (let i = 0; i < aProps.length; i += 1) {
		const propName = aProps[i];

		if (a[propName] !== b[propName]) {
			return false;
		}
	}
	return true;
}

const obj = {
	a: 1,
	b: {
		c: 2,
		d: {
			e: 3,
			f: 4,
		},
	},
};
const obj1 = {
	a: 1,
	b: {
		c: 2,
		d: {
			e: 3,
			f: 4,
		},
	},
};
console.log(isObjectEqual(obj, obj1));
```

</details>
<details>
<summary>
What is shallow equal?
</summary>

```js
function isObjectEqual(a, b) {
	// Create arrays of property names
	const aProps = Object.getOwnPropertyNames(a);
	const bProps = Object.getOwnPropertyNames(b);

	// If their property lengths are different, they're different objects
	if (aProps.length !== bProps.length) {
		return false;
	}

	for (let i = 0; i < aProps.length; i += 1) {
		const propName = aProps[i];

		if (a[propName] !== b[propName]) {
			return false;
		}
	}
	return true;
}
```

</details>
<details>
<summary>
Using classes write a program to build a Parking Lot.
</summary>

</details>