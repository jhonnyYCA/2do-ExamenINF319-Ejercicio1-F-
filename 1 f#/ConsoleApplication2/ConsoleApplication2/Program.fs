// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System 

let fibonacci n =
  let mutable a = 0
  let mutable b = 1

  if n=1 then   printf "%d " a
  if n=2 then   printf "%d " a 
                printf "%d " b
  if n>=3 then   
    for i in 1..n do
       printf "%d " a
       
       let mutable f = a+b
       a <- b
       b <- f

   
let rec fibonacciRecursivo n =
    match n with
    | 0 | 1 -> n
    | n -> fibonacciRecursivo (n-1) + fibonacciRecursivo (n-2)     

[<EntryPoint>]
let main argv = 
  
    let n=Console.ReadLine()
    let nn=Convert.ToInt32(n)

    Console.WriteLine(fibonacci nn)

    for i in 0..nn-1 do
       Console.Write(fibonacciRecursivo i)
       Console.Write(" ")
    
    let tecla =  Console.ReadKey()
    0 // devolver un código de salida entero
     // devolver un código de salida entero
