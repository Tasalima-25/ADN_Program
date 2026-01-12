class Exp1
{
    public static void Main()
    {
        int num1=10;
        int num2=20;

        int add=num1+num2;
        int sub=num1-num2;
        int mul=num1*num2;
        int div=num1/num2;
        int mod=num1%num2;
        num1++;
        num2--;

        System.Console.WriteLine("Addition:"+add);
        System.Console.WriteLine("Substraction:"+sub);
        System.Console.WriteLine("Multiplication:"+mul);
        System.Console.WriteLine("Division:"+div);
        System.Console.WriteLine("Modulus:"+mod);
        System.Console.WriteLine("Increment:"+num1);
        System.Console.WriteLine("Decrement:"+num2);

    }
}