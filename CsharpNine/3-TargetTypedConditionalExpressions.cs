
var isOdd = true;
MyFunction(isOdd ? 1 : 2);


void MyFunction(long number) =>
    System.Console.WriteLine($"{number.GetType()}: {number}");


// void MyFunction(short number) => 
//     System.Console.WriteLine($"{number.GetType()}: {number}");

// MyFunction(isOdd ? (short)1 : (short)2);
