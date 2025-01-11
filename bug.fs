let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 20 which is expected

//However if we do it in a function like below:
let swapInFunction x y =
    let mutable x1 = x
    let mutable y1 = y
    let temp = x1
    x1 <- y1
    y1 <- temp
    (x1, y1)

let a = 10
let b = 20
let (a1,b1) = swapInFunction a b
printf "%d %d %d %d" a b a1 b1 //This will print 10 20 20 10, which is unexpected