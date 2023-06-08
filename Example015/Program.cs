// ==== РЕКУРСИЯ ====

// = Факториал числа = 

// 1! = 1   // факториал 1 = 1
// 0! = 1   // факториал 0 = 1

int Factorial(int n)    // создали возвращаемый метод, который на вход принимает одно чтсло (int n) и возвращает результат
{
    if (n == 1) return 1;   
    else return n * Factorial(n-1);
}


Console.WriteLine(Factorial(0));    // выводим на консоль результат путем запуска метода в функционале Console.WriteLine
                                    // в скобках указываем входное число, факторил которого надо вычислить



// == ФАКТОРИАЛ ДЛЯ БОЛЬШИХ ЧИСЕЛ ==

double Factorial2(int n)   // для больших чисел int не вмещает итоговый результат, поэтому применяем тип данных double
{
    if (n == 1) return 1;   
    else return n * Factorial2(n-1);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial2(i)}");
}



// == ЧИСЛА ФИБОНАЧЧИ ==

// Числа Фибоначчи - это числа, которые равны сумме двух предыдущих чисел.

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)


int Fibonacci (int n)
{
    if(n == 1 || n ==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);

}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine(Fibonacci(i));
}


