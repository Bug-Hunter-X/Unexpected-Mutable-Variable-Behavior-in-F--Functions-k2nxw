let swap x y =
    let temp = x
    x <- y
    y <- temp

let swapInFunction x y =
    let temp = x
    x <- y
    y <- temp
    (x,y)

//OR

let swapInFunction2 x y = (
    let mutable x1 = x
    let mutable y1 = y
    let temp = x1
    x1 <- y1
    y1 <- temp
    x1,y1)

let a = 10
let b = 20

swap a b // swap a and b directly
printf "%d %d" a b //Prints 20 10

let (a1,b1) = swapInFunction a b // swap a and b in a function
printf "%d %d %d %d" a b a1 b1 //Prints 20 10 20 10

let (a2, b2) = swapInFunction2 a b
printf "%d %d %d %d" a b a2 b2//Prints 20 10 20 10