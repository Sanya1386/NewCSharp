// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int n = 10;
int[] arr = { 2, 5, 4, 7, 8, 35, 1, 3, 8, 5 };
int i = 0;

while (i < n)
{
    if(arr[i] % 2 == 0)
    {
        System.Console.Write(arr[i] + " ");
       
    }
    i = i + 1;
}