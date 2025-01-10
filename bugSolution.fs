let mutable x = 10

let addOne () = x <- x + 1

addOne ()

printf "%d" x // This will print 11