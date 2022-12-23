Console.WriteLine("Hello, World!");
int a = 1; //1
int b = 1; //2
Теперь не работает!!!
for (int i = 0; i < 8; i++){
    (a,b) = (b, a+b);
}
//2,3
//3,4
//5,6
//6,7
//7,8
//8,9
//9,10 = 55

Console.WriteLine(b);
