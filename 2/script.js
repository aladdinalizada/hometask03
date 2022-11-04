var a = [35, 10, 31, 11, 26];    
function print() //function to print array elements  
{  
for(i = 0; i < 5; i++)     
{    
    document.writeln(a[i]);    
}    
}  
document.write("Before sorting array elements are - " + "<br>");    
 print();  
  
for(i = 0; i < 5; i++)    
{    
    for (j = 0; j < 5; j++)    
    {    
        if(a[i] < a[j])    
        {    
            temp = a[i];    
            a[i]=a[j];    
            a[j] = temp;     
        }    
    }    
}    
document.write("<br> After sorting array elements are - " + "<br>");    
print();  