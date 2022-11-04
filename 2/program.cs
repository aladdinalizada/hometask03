using System;  
// ilk once bubble sort ile arrayin elelmetlerini sira ile duzdum
public class Bubble   
{  
    static void print (int[]a)  //function to print array elements  
    {  
        int n = a.Length;  
        int i;  
        for (i = 0; i < n; i++)  
        {  
            Console.Write (" " + a[i]);  
        }  
          
    }  
    static void bubble (int[]a) // function to implement bubble sort  
    {  
        int n = a.Length;  
        int i, j, temp;  
        for (i = 0; i < n; i++)  
        {  
            for (j = i + 1; j < n; j++)  
            {  
                if (a[j] < a[i])  
                {  
                    temp = a[i];  
                    a[i] = a[j];  
                    a[j] = temp;  
                }  
            }  
        }  
    }  
    public static void Main ()   
    {  
        int[] a = { 45, 1, 32, 13, 26 };  
        Console.Write ("\n Before sorting array elements are - \n");  
        print (a);  
        bubble (a);  
        Console.WriteLine ();  
        Console.Write ("\n After sorting array elements are - \n");  
        print (a);  
    }   
    
    int[] a = {1, 13, 26, 32, 45} // artan sira ile yazilmis formasi
    
} 