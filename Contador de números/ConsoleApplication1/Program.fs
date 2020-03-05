open System
let myList = [0..9]
let myFunction =
for n in myList do
    Console.WriteLine(n)

Console.ReadKey()