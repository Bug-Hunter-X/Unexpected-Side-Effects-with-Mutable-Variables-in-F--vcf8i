let mutable x = 10
let mutable y = 20

let add x y = x + y

let z = add x y
printf "%d\n" z

x <- 15 //this will modify the value of x which is not the expected behaviour
y <- 25 //this will modify the value of y which is not the expected behaviour

let z2 = add x y
printf "%d\n" z2