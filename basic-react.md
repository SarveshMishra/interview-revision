<details>
<summary>
What is a babel?
</summary>

<p>
A babel is a tool that allows you to convert a JavaScript code to a different programming language. Babel is transpiler means that it compile the code from one high level language to another. It handles the version of code written in high level language to the version that browser can understand.
</p>
</details>

<details>
<summary>
What is webpack?
</summary>

<p>
Webpack is a bundler of different files written in js or other language and compile them very short minified version of which is basically machine readable and hard for human to understand. Basically it reduces the size by replacing the variables and other things with something that contains less byte code.
</p>
</details>

<details>
<summary>
What is setState?
</summary>
<p>
setState is a method that allows you to change the state of the component. In class component there is single state which handle state of the component but in function component we use state hooks to handle different state variable with different setState method.
</p>
</details>

<details>
<summary>
What is the difference between state and props?
</summary>
<p>
State is the variable that is used to store the data of the component. Props is the variable that is used to pass data from parent to child. State are mutable and props are immutable because they are passed from parent to child.

</p>
</details>

<details>
<summary>
What is Virtual DOM?
</summary>
<p>
Virtual DOM is a tree structure that is used to represent the DOM. It is used to compare the DOM and the Virtual DOM and if there is any difference then only it will update the DOM. It is used to improve the performance of the application. It can not control the DOM directly. 
</p>
</details>

<details>
<summary>
What are React Portals?
</summary>
<p>
React portals are used to render the component in the DOM. 
</p>
</details>

<details>
<summary>
What is context API?
</summary>
<p>
Context API provides a way to pass data through the component tree without having to pass props down manually at every level. It provides a way to share values like language, theme, or any other data that functions like state. It is like global store for the application any component can exchange data with other components. It minimize the prop drilling.
</p>
</details>

<details>
<summary>
What are Life cycle methods in React?
</summary>
<p>
There are three phases of the life cycle of a component. Mounting, Updating and Unmounting. Mounting is when the component is first added to the DOM. Updating is when the component is updated. Unmounting is when the component is removed from the DOM.
Mounting: React has three basic methods that are called during the mounting phase.
constructor()
render()
componentDidMount()

Updating:
render()
componentDidUpdate()

Unmounting:
componentWillUnmount()

</p>
</details>

<details>
<summary>
How can you memoize components in React?
</summary>
<p>
Memoize components in React by using the React.memo() function.
</p>
</details>

<details>
<summary>
How do you do testing on React?
</summary>
<p>
Testing on React is done by using Jest.
</p>
</details>

<details>
<summary>
What is the difference between State and Props?
</summary>
<p>
State is the variable that is used to store the data of the component. Props is the variable that is used to pass data from parent to child. State are mutable and props are immutable because they are passed from parent to child.
</p>
</details>

<details>
<summary>
What is the dependency array in hooks? How many values can you pass into it?
</summary>
<p>
Dependency array is an array of values that are passed into the hook. It is passed so that by changing the value the function will be called again. It is used to avoid the re-rendering of the component. If we pass nothing that is empty array then it will be called when component is first rendered. If we pass one value then it will be called when the value is changed. If we pass more than one value then it will be called when any of the value is changed.
The React hooks that have dependency arrays are:  useEffect, useContext, useReducer, useCallback, useMemo, useRef, useImperativeHandle, and useLayoutEffect.
</p>
</details>

<details>
<summary>
What happens when you return something inside a useEffect? When does it get called?
</summary>
<p>
When you return something inside a useEffect it will be called when the component is first rendered and when the component is updated.
</p>
</details>

<details>
<summary>
What are memory leakages?
</summary>
<p>
Memory leaks in React applications are primarily a result of not cancelling subscriptions made when a component was mounted before the component gets unmounted. These subscriptions could be a DOM Event listener, a WebSocket subscription, or even a request to an API.

According to MDN, the AbortController represents a controller object that allows you to abort one or more Web requests as and when desired. That's quite explanatory!!

AbortControllers are created with the new AbortController() syntax, initializing an instance of the AbortController class. Every AbortController object has a read-only signal property which is passed into requests, and an abort() method which is whenever you want to cancel a request.

</p>
</details>

<details>
<summary>
When are custom hooks?
</summary>
<p>
Custom hooks are hooks that are not built into React. They are written by the developer. They are used to handle state and other variables.
</p>
</details>

<details>
<summary>
What are the rules of hooks?
</summary>
<p>
The rules of hooks are:
1. Only Call Hooks at the Top Level
2. Only Call Hooks from React Functions
3. Hooks can only be called inside React Functions
</p> 
</details>

<details>
<summary>
What is useReducer?
</summary>
<p>
useReducer is a hook alternative to useState we can use this for complex state handling and it is similar to redux. It prefers over useState when logic involve sub-values or prev state. 
</p>
<code>
const [state, dispatch] = useReducer(reducer, initialArg, init);
</code>

</details>

<details>
<summary>
What is the difference in Context and Redux
</summary>
<p>
Context is a way to share values like language, theme, or any other data that functions like state. It is like global store for the application any component can exchange data with other components. It minimize the prop drilling. Redux is a library that is used to handle state. It is a single source of truth. It has own reducer and actions and state. 
Context is for small use cases and debugging is hard in context api but in redux you can use redux dev tools and single store and reducer to debug. So redux prefer for large state management. 
</p>
</details>

<details>
<summary>
Explain redux to a 5 year old (ELI5) ?
</summary>
<p>
Let say you are parent and you have to give candy to your child and you have to give different candies to different children. You can use redux to handle this. Basically you have to just create different boxes and you can use reducer to handle this. For each children you have placed boxes in home and children don't have to ask their siblings for candy they can directly access their boxes and take candy. So here home is global store and different boxes or separate stores with action and reducer and state. Each children act as a component and they can access their own store.
</p>
</details>

<details>
<summary>
what does useSelector do?
</summary>
<p>
useSelector is a hook that allows you to read from the store. It takes a selector function as an argument and returns the result of calling that selector with the current state.
</p>
</details>

<details>
<summary>
What is immutability?
</summary>
<p>
Immutability means in simple words can not change the value of a variable. Immutability is a property of data structures that states that once a value is assigned to a variable, it cannot be changed. For example declaring variable with const and props in a component.
</p>
</details>

<details>
<summary>
Why do we need to spread the state in redux?
</summary>
<p>
When you have multiple reducers and you want to access the state of any reducer you can use the spread operator. Basically spread operator restore the previous state of the reducer.
</p>
</details>

<details>
<summary>
What does Object.freeze() do?
</summary>
<p>
Object.freeze() is a method that freezes an object. It prevents the object from being modified. It is used to prevent accidental modification of the object. Basically it makes the object immutable.
</p>
</details>

<details>
<summary>
Why is immutability required by Redux?
</summary>
<p>
Basically immutability improve faster equality checks with previous state. So redux create a copy of previous state and do shallow check and update new state by copying the previous state.
</p>
</details>

<details>
<summary>
How does Redux use shallow equality checking?
</summary>
<p>
Redux uses shallow equality checking to determine whether the state has changed. It compares the current state with the previous state. If the current state is equal to the previous state, then the state is not changed. If the current state is not equal to the previous state, then the state is changed.
Shallow checking means only performing reference equality checks not value equality checks. Deeper equality check require more recursive value checking for each property.

</p>
</details>

<details>
<summary>
How well does Redux “scale” in terms of performance and architecture?
</summary>
<p>
Redux is a scalable architecture. It is scalable because it is easy to add new features to the application. It is easy to add new reducers and actions. It is easy to add new components.
</p>
</details>

<details>
<summary>
What is JSX?
</summary>
<p>
JSX is a syntax extension to JavaScript. It is used to write HTML inside JavaScript. It is used to write React components and babel converts it to JavaScript.
</p>
</details>

<details>
<summary>
What is Conditional Rendering?
</summary>
<p>
Conditional rendering is a technique that allows you to render a component based on some condition. It is used to render a component only when a certain condition is true. For example, show profile page only when the user is logged in other wise show login page.
</p>

</details>

<details>
<summary>
What is tree-shaking ?
</summary>
<p>
Tree Shaking means in dom is to remove unused code while rendering. It is used to remove unused code from the bundle. Basically it is used by webpack to remove dead code to remove any side effect and reduce the size of the bundle.
</p>
</details>

<details>
<summary>
What are some features of using webpack?
</summary>
<p>
Using webpack we can use different loaders and configuration for our projects. We can configure it store js not in one file but store in chunks so that file will be only send when front end required not all at a same time. It does tree shaking by default so if you have any dead code in your development phase so it will not be bundled. It can also be used to minify the bundle.
</p>
</details>

<details>
<summary>
What are Controlled and Uncontrolled components?
</summary>
<p>
Controlled component means single source of truth and it is controlled by the parent component. Uncontrolled component means it is not controlled by parent and by default it is taken care by element. For example, take an input element if you want to take the value you can do it without using controlled component but it is good practice to make single source of truth in react because it follows unidirectional flow. FLUX architecture is a good example of controlled component.
</p>
</details>

<details>
<summary>
What is flux architecture?
</summary>
<p>
FLUX architecture is designed by Facebook it means single source of truth. It is a good example of controlled component or redux store. It follow unidirectional flow. 
</p>
</details>

<details>
<summary>
What does React.useCallback do?
</summary>
<p>
React.useCallback is a hook that returns a memoized callback. It takes a callback and an optional array of dependencies. It returns a memoized version of the callback that only changes if one of the dependencies has changed.
</p>
</details>

<details>
<summary>
What does React.memo mean?
</summary>
<p>
React.memo is a React component that is optimized for pure components. It is a wrapper around React.createElement. It is a performance optimization that only renders a component if its props or some of the props that should be hashed have changed.
</p>
</details>

<details>
<summary>
What is Higher-order Components?
</summary>
<p>
Higher-order components are components that take other components as props. They are used to compose components. For example, index.js or app.js is higher-order component. It is a good example of HOC. They compose components from different sub-components.
</p>
</details>

<details>
<summary>
What are keys in React? Why are keys important?
</summary>
<p>
Keys are important in react because react follow Virtual DOM management. It is used to identify which elements are new and which elements are old. It helps in optimizing the virtual DOM.
</p>
</details>

<details>
<summary>
What is reconciliation?
</summary>
<p>
Reconciliation is a process of comparing the virtual DOM with the real DOM. It is used to update the real DOM. With the helps of keys it helps in identifying which elements are new and which elements are old.
</p>
</details>

<details>
<summary>
What does the cleanup function in useEffect do?
</summary>
<p>
Cleanup function invokes when the component is unmounted. It is used to clean up the resources. It avoid memory leak. For example, clearTimeout, clearInterval, AbortController etc.
</p>
</details>
