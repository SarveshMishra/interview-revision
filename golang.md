# Revision topics for GoLang Interview


## Basics

### Introduction

- Go is a statically typed, compiled programming language designed for simplicity and efficiency.
- It was created at Google in 2007 and released to the public as an open-source language in 2009.
- Go is known for its concurrency support, garbage collection, and strong standard library.
- It is often used for building web servers, networking tools, and cloud-based applications.

### Key Features
- **Concurrency**: Go has built-in support for concurrent programming with goroutines and channels, making it easy to write programs that can perform multiple tasks simultaneously.
- **Garbage Collection**: Go has an automatic garbage collector that helps manage memory, reducing the risk of memory leaks and improving performance.
- **Strong Standard Library**: Go comes with a rich standard library that provides many packages for common tasks, such as HTTP handling, file I/O, and cryptography.
- **Cross-Platform**: Go can be compiled to run on various operating systems and architectures, making it suitable for cross-platform development.
- **Simplicity**: Go has a clean and simple syntax, making it easy to read and write. It avoids complex features found in other languages, such as inheritance and generics (though generics were introduced in Go 1.18).
- **Fast Compilation**: Go is designed for fast compilation times, allowing developers to quickly build and test their code.
- **Static Typing**: Go is statically typed, meaning that variable types are known at compile time, which helps catch errors early in the development process.
- **Interfaces**: Go uses interfaces to define behavior, allowing for flexible and modular code design. Interfaces enable polymorphism and decoupling of components.
- **Error Handling**: Go uses a unique error handling approach, where functions return an error value that must be checked explicitly. This encourages developers to handle errors properly and improves code reliability.
- **Tooling**: Go has a rich set of tools for formatting, testing, and building code. The `go` command-line tool provides commands for managing dependencies, running tests, and generating documentation.

### Basic Syntax

- **Hello World**:
```go
package main
import "fmt"
func main() {
    fmt.Println("Hello, World!")
}
```
- **Variables**:
```go
package main
import "fmt"
func main() {
    var x int = 10 // Explicit type declaration
    y := 20       // Short variable declaration (type inferred)
    fmt.Println(x, y)
}
```
- **Constants**:
```go
package main
import "fmt"
const Pi = 3.14 // Constant declaration
func main() {
    fmt.Println(Pi)
}
```
- **Control Structures**:
```go
package main
import "fmt"
func main() {
    // If-else statement
    x := 10
    if x > 0 {
        fmt.Println("Positive")
    } else {
        fmt.Println("Non-positive")
    }

    // Switch statement
    day := 3
    switch day {
    case 1:
        fmt.Println("Monday")
    case 2:
        fmt.Println("Tuesday")
    case 3:
        fmt.Println("Wednesday")
    default:
        fmt.Println("Other day")
    }
}
```

- **Loops**:
```go
package main
import "fmt"
func main() {
    // For loop
    for i := 0; i < 5; i++ {
        fmt.Println(i)
    }

    // While loop (using for)
    j := 0
    for j < 5 {
        fmt.Println(j)
        j++
    }
}
```
- **Arrays and Slices**:
```go
package main
import "fmt"
func main() {
    // Array
    var arr [5]int = [5]int{1, 2, 3, 4, 5}
    fmt.Println(arr)

    // Slice
    slice := []int{1, 2, 3, 4, 5}
    fmt.Println(slice)

    // Append to slice
    slice = append(slice, 6)
    fmt.Println(slice)
}
```
- **Maps**:
```go
package main
import "fmt"
func main() {
    // Map
    m := make(map[string]int)
    m["a"] = 1
    m["b"] = 2
    fmt.Println(m)

    // Accessing map values
    fmt.Println(m["a"])
}
```
- **Structs**:
```go
package main
import "fmt"
type Person struct {
    Name string
    Age  int
}
func main() {
    // Struct initialization
    p := Person{Name: "Alice", Age: 30}
    fmt.Println(p)

    // Accessing struct fields
    fmt.Println(p.Name, p.Age)
}
```
- **Functions**:
```go
package main
import "fmt"
func add(a int, b int) int {
    return a + b
}
func main() {
    result := add(5, 10)
    fmt.Println(result)
}
```
- **Pointers**:
```go
package main
import "fmt"
func main() {
    x := 10
    p := &x // Pointer to x
    fmt.Println(*p) // Dereferencing the pointer
    *p = 20         // Changing the value of x through the pointer
    fmt.Println(x)
}
```
- **Interfaces**:
```go
package main
import "fmt"
type Shape interface {
    Area() float64
}
type Circle struct {
    Radius float64
}
func (c Circle) Area() float64 {
    return 3.14 * c.Radius * c.Radius
}
type Rectangle struct {
    Width, Height float64
}
func (r Rectangle) Area() float64 {
    return r.Width * r.Height
}
func main() {
    var s Shape
    s = Circle{Radius: 5}
    fmt.Println(s.Area()) // Output: 78.5

    s = Rectangle{Width: 4, Height: 5}
    fmt.Println(s.Area()) // Output: 20
}
```
- **Error Handling**:
```go
package main
import "fmt"
import "errors"
func divide(a, b int) (int, error) {
    if b == 0 {
        return 0, errors.New("division by zero")
    }
    return a / b, nil
}
func main() {
    result, err := divide(10, 0)
    if err != nil {
        fmt.Println(err)
    } else {
        fmt.Println(result)
    }
}
```
- **Concurrency**:
```go
package main
import "fmt"
import "time"
func sayHello() {
    for i := 0; i < 5; i++ {
        fmt.Println("Hello")
        time.Sleep(1 * time.Second)
    }
}

func main() {
    go sayHello() // Start a goroutine
    for i := 0; i < 5; i++ {
        fmt.Println("World")
        time.Sleep(1 * time.Second)
    }
}
```

- **Select Statement**:
```go
package main
import "fmt"
import "time"
func main() {
    ch1 := make(chan string)
    ch2 := make(chan string)

    go func() {
        time.Sleep(2 * time.Second)
        ch1 <- "Message from channel 1"
    }()

    go func() {
        time.Sleep(1 * time.Second)
        ch2 <- "Message from channel 2"
    }()

    select {
    case msg1 := <-ch1:
        fmt.Println(msg1)
    case msg2 := <-ch2:
        fmt.Println(msg2)
    }
}
```
- **Defer Statement**:
```go
package main
import "fmt"
func main() {
    defer fmt.Println("Deferred statement")
    fmt.Println("Main function")
}
```
- **Anonymous Functions**:
```go
package main
import "fmt"
func main() {
    func() {
        fmt.Println("Anonymous function")
    }()
}
```
- **Closure**:
```go
package main
import "fmt"
func main() {
    counter := func() func() int {
        count := 0
        return func() int {
            count++
            return count
        }
    }()

    fmt.Println(counter()) // Output: 1
    fmt.Println(counter()) // Output: 2
}
```
- **Type Assertion**:
```go
package main
import "fmt"
type Animal interface {
    Speak() string
}
type Dog struct {}
func (d Dog) Speak() string {
    return "Woof!"
}
type Cat struct {}
func (c Cat) Speak() string {
    return "Meow!"
}
func main() {
    var a Animal = Dog{}
    fmt.Println(a.Speak()) // Output: Woof!

    if dog, ok := a.(Dog); ok {
        fmt.Println("It's a dog:", dog.Speak())
    } else {
        fmt.Println("It's not a dog")
    }
}
```
- **Channels**:
```go
package main
import "fmt"
import "time"
func worker(ch chan string) {
    for msg := range ch {
        fmt.Println(msg)
    }
}
func main() {
    ch := make(chan string)
    go worker(ch) // Start a goroutine

    for i := 0; i < 5; i++ {
        ch <- fmt.Sprintf("Message %d", i)
        time.Sleep(1 * time.Second)
    }
    close(ch) // Close the channel
}
```
- **Go Routine**:
```go
package main
import "fmt"
import "time"
func main() {
    go func() {
        for i := 0; i < 5; i++ {
            fmt.Println("Goroutine:", i)
            time.Sleep(1 * time.Second)
        }
    }()

    for i := 0; i < 5; i++ {
        fmt.Println("Main:", i)
        time.Sleep(1 * time.Second)
    }
}
```
- **WaitGroup**:
```go
package main
import "fmt"
import "sync"
import "time"
func worker(wg *sync.WaitGroup, id int) {
    defer wg.Done() // Decrement the counter when the goroutine completes
    fmt.Printf("Worker %d started\n", id)
    time.Sleep(2 * time.Second) // Simulate work
    fmt.Printf("Worker %d finished\n", id)
}
func main() {
    var wg sync.WaitGroup
    for i := 1; i <= 3; i++ {
        wg.Add(1) // Increment the counter
        go worker(&wg, i) // Start a goroutine
    }
    wg.Wait() // Wait for all goroutines to finish
    fmt.Println("All workers completed")
}
```
- **Mutex**:
```go
package main
import "fmt"
import "sync"
import "time"
func main() {
    var mu sync.Mutex
    var counter int

    var wg sync.WaitGroup
    for i := 0; i < 5; i++ {
        wg.Add(1) // Increment the counter
        go func() {
            defer wg.Done() // Decrement the counter when the goroutine completes
            mu.Lock() // Lock the mutex
            counter++
            mu.Unlock() // Unlock the mutex
        }()
    }
    wg.Wait() // Wait for all goroutines to finish
    fmt.Println("Final counter value:", counter)
}
```


### Advanced Topics

- **Interfaces**: Interfaces in Go are a way to define behavior without specifying the concrete implementation. They allow for polymorphism and decoupling of components.
- **Reflection**: Reflection in Go allows you to inspect the type and value of variables at runtime. It is useful for writing generic code and working with unknown types.
- **Testing**: Go has a built-in testing framework that allows you to write unit tests for your code. You can use the `testing` package to create test functions and run them using the `go test` command.
- **Profiling**: Go provides tools for profiling your code to identify performance bottlenecks. You can use the `pprof` package to generate CPU and memory profiles.
- **Context**: The `context` package in Go provides a way to manage cancellation and timeouts for goroutines. It is commonly used in concurrent programming to control the lifecycle of operations.
- **Generics**: Generics allow you to write functions and data structures that can work with any type. Go introduced generics in version 1.18, enabling more flexible and reusable code.
- **Modules**: Go modules are a way to manage dependencies in Go projects. They allow you to define module versions and ensure that your code works with specific versions of dependencies.
- **Error Handling**: Go uses a unique error handling approach where functions return an error value that must be checked explicitly. This encourages developers to handle errors properly and improves code reliability.


### Common Libraries
- **net/http**: Provides HTTP client and server implementations.
- **encoding/json**: Provides functions for encoding and decoding JSON data.
- **fmt**: Provides formatted I/O functions for printing and scanning data.
- **os**: Provides functions for interacting with the operating system, such as file I/O and environment variables.
- **time**: Provides functions for working with time and dates.
- **sync**: Provides synchronization primitives such as mutexes and wait groups for concurrent programming.
- **context**: Provides a way to manage cancellation and timeouts for goroutines.
- **log**: Provides a simple logging package for writing log messages.
- **math**: Provides basic mathematical functions and constants.
- **strconv**: Provides functions for converting between strings and other data types.
- **errors**: Provides functions for creating and handling errors.
- **flag**: Provides a way to parse command-line flags and arguments.

