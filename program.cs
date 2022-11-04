using System;  
class Selection {  
static void selection(int[] arr)  
{  
    int i, j, small;  
    int n = arr.Length;  
    for (i = 0; i < n-1; i++)    // One by one move boundary of unsorted subarray  
    {  
        small = i; //minimum element in unsorted array  
          
        for (j = i+1; j < n; j++)  
        if (arr[j] < arr[small])  
            small = j;  
// Swap the minimum element with the first element  
    int temp = arr[small];  
    arr[small] = arr[i];  
    arr[i] = temp;  
    }  
}  
  
static void printArr(int[] a) /* function to print the array */  
{  
    int i;  
    int n = a.Length;  
    for (i = 0; i < n; i++)  
    Console.Write(a[i] + " ");  
}  
  
  static void Main() {  
    int[] a = { 85, 50, 29, 18, 7, 30, 3};  
    Console.Write("Before sorting array elements are - ");  
    printArr(a);  
    selection(a);  
    Console.Write("\nAfter sorting array elements are - ");    
    printArr(a);  
  }  
} 