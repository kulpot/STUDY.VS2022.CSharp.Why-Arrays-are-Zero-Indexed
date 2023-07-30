using System;

//ref link:https://www.youtube.com/watch?v=KJxW2y69XEE&list=PLRwVmtr-pp07QlmssL4igw1rnrttJXerL&index=8
//pointers in C++ --- creates damages
// In C# arrays are object but not in C++
// ctrl+alt+d --- go to disassembly window
//f11 -- go to registry in debug mode
// why array is set to 0 bytes because of issues in off setting further in to the array

class MainClass
{
    static void Main()
    {
        int[] myArray = new int[] { 5, 2, 8, 4, 1 };
        unsafe
        {
            fixed(int* p = myArray) //fixed keyword -- not allow garbage to move around
            {
                // Console.WriteLine(*p);    // * -- dereference
                Console.WriteLine(*(p + 1)); // 4 bytes of memory(int) + 1(index) = 2 myArray
                Console.WriteLine(*(p + 2)); // 4 bytes of memory(int) + 2(index) = 8 myArray
                Console.WriteLine(*(p + 0)); // 4 bytes of memory(int) + 0(index) = 5 myArray
                Console.WriteLine(*(p + 3)); // 4 bytes of memory(int) + 1(index) = 4 myArray
                Console.WriteLine(myArray[0]);  // output 5 because binary language starts in 0
            }
        }
    }
}