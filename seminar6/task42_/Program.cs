/**Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10**/

bintype(91);
for (int i = 0; i < 32; i++)
{
    Console.Write(arr[i]);
}

Console.WriteLine("введите число");
int a=Convert.ToInt32(Console.ReadLine());
int b=a;
int count=0;
    while(b!=0){
        count++;
        b=b/2;
    }
int[] c=new int[count];
    while(a!=0){
        for(int i=0;i<c.Length;i++){
            c[i]=a%2;
            a=a/2;
        }
    }
string s="";
for (int i = c.Length-1; i >= 0; --i){
s+=c[i].ToString();}
Console.WriteLine(s);