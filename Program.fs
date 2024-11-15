// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from Chahat"
//open System
//let square x = x*x
//let cube x= x*x*x
//let sign x=

           //if x>5 then "positive"
           //else if x<4 then "negative"
          // else "zero"
//et passFive f =(f 0)
//printfn "%A" (passFive square)
//printfn "%A" (passFive cube)
//printfn "%A" (passFive sign)


//let rec recursion n =
    //if n <= 1 then
      //  n
    //else
  //      n + recursion (n - 1)
 
//let x = recursion 10
//printfn "%A" x


//let rec factorial x =
     //    if x < 1 then 1
    //     else
  //            x * factorial(x-1) 
      
//let res = factorial(6)

//printfn "%A" res


//let NumberAry = [|1;2;3;4|]
 
//printfn "%A" NumberAry
 
//printfn "%A" NumberAry.[2]
 
//let newArray = Array.append NumberAry [|11;12;13|]
 
//printfn "%A" NumberAry
 
//printfn "%A" newArray
 
//let newArray2 = NumberAry |> Array.append [|11;12;13|]
 
//printfn "%A" NumberAry
 
//printfn "%A" newArray2


//let list = [1;2;3;4;5]

//for  i in  list do
  //  printfn "%d" i

//let inventory = [ "Apples", 0.33; "Oranges", 0.23; "Bananas", 0.45 ] |> Map.ofList
 
// Use tryFind to safely get the value for a key that may not exist
//let apples = 
    //match Map.tryFind "Apples" inventory with
    //| Some price -> price
  //  | None -> 0.0 // Default or fallback value if "Apples" doesn't exist
 
//let pineapples = 
    //match Map.tryFind "Pineapples" inventory with
    //| Some price -> price
  //  | None -> 0.0 // Default or fallback value if "Pineapples" doesn't exist
 
// Add a new item "Pineapples" and remove "Apples" from the map
//let newInventory = 
    //inventory 
    //|> Map.add "Pineapples" 0.87 
  //  |> Map.remove "Apples"
 
// Optional: Print results to verify
//printfn "Apples price: %f" apples
//printfn "Pineapples price: %f" pineapples
//printfn "Updated Inventory: %A" newInventory

//let f = fun n -> n*n
//let squarecal= [2;3;4;5] |> List.map f

//printfn "%A" squarecal



//let something = [4;5;6;7]

//something |> List.iter (printfn "%A")

//let neList = something |> List.collect (fun x ->[1..x])

//printfn "%A" neList

let rec product lst acc =
    match lst with
    | [] -> acc
    | x :: xs -> product xs (acc * x)

let numbers = [1; 2; 3; 4; 5; 6; 7;8 ]
let result = product numbers 1
printfn "output 1:"
printfn "The product of the list is: %d" result


let rec productOfOdds n acc =
    if n < 1 then acc // Base case: if n is less than 1, return the accumulated product
    else productOfOdds (n - 2) (acc * n) // Recursive step: multiply n with the accumulator and call with (n-2)

let pass = productOfOdds 11 1 // Start with 11 and an initial accumulator value of 1
printfn "output 2:"
printfn "The product of all odd numbers is: %d" pass



let names = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]

let trimmedNames = names |> List.map (fun name -> name.Trim()) // Use String.Trim() for each element

// Print the trimmed names
printfn "output 3:"
printfn "Trimmed names: %A" trimmedNames


// Generate a sequence of the first 700 positive integers
let numberskeys = seq { 1 .. 700 }

// Convert the sequence to a list
let numberList = Seq.toList numberskeys

// Filter out numbers that are multiples of both 7 and 5
let filteredNumbers = numberList |> List.filter (fun x -> x % 7 = 0 && x % 5 = 0)

// Sum all the filtered numbers using the fold function
let totalSum = filteredNumbers |> List.fold (fun acc x -> acc + x) 0

// Print the result
printfn "output 4:"
printfn "The sum of all filtered numbers is: %d" totalSum




// Initial list of strings
let name = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]

// Filter names containing the letter "I" (case-insensitive)
let filteredNames = 
    name
    |> List.filter (fun name -> name.ToUpper().Contains("E"))

// Concatenate the filtered names using fold
let concatenatedNames = 
    filteredNames 
    |> List.fold (fun acc name -> acc + name) ""

// Print the result
printfn "output 5:"
printfn "Concatenated names: %s" concatenatedNames

