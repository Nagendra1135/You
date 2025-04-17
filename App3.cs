using System;
class App3{
    int x=23,y=25;
    static int p=33,q=44;
    const int a1=78;
    readonly int b=9;
    void add(){
        int c=34;
        Console.WriteLine(c);
    } 
    static void Main(string[] args){
        App3 a=new App3();
        Console.WriteLine(a.x+a.y);
        Console.WriteLine(p-q);
    Console.WriteLine(App3.a1);
    Console.WriteLine(a.b);

    }

}