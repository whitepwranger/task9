//Задача 64
int n,m;

void show_num(int n){
    if(n != 0){
        Console.WriteLine(n);
        show_num(n - 1);
    }
}

Console.WriteLine("enter number:");
n = int.Parse(Console.ReadLine());
show_num(n);
 //Задача 66
int show_sum(int n,int m){
    int r = n;
    if(n < m){
        r += show_sum(n + 1,m);
    }
    return r;
}

Console.WriteLine("enter range:");
n = int.Parse(Console.ReadLine());
m = int.Parse(Console.ReadLine());
Console.WriteLine(show_sum(n,m));

//Задача 68
int ack(int n, int m){
    if(n == 0){
        return m + 1;
    } else if(m == 0){
        return ack(n - 1, 1);
    }
    return ack(n - 1,ack(n, m - 1));
}
Console.WriteLine("enter 2 numbers:");
n = int.Parse(Console.ReadLine());
m = int.Parse(Console.ReadLine());
Console.WriteLine(ack(n,m));