let x = 10
let y = 20

let add x y = x + y

let z = add x y
printf "%d\n" z

//Modifying x and y here will NOT affect the previous calculation of z
let x2 = 15
let y2 = 25

let z2 = add x2 y2
printf "%d\n" z2