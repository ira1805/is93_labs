#include <iostream>
#include "Expression.h"

using namespace std;

int main()
{
    setlocale(LC_ALL, "Ukrainian");
    Expression A[3] = {
                Expression(2, 5, 3, 40),
                Expression(1, 0, 0, 5),
                Expression(15, 10, 5, 25)
    };
    // Обчислення виразу для об'єктів та виведення результатів

    printf("Значення виразів:\n%F\n%F\n%F\n", A[0].Calculate(), A[1].Calculate(), A[2].Calculate());

    
    A[0].Change('a', 7);
    printf("Результат першого виразу при зміни операнди:\n%F\n", A[0].Calculate());

    // Приклади виразів що призводять до виняткових ситуацій
    // Корінь менше нуля
    Expression Err1 = Expression(1, 2, 3, 42);
    // Дільник дорівнює нулю
    Expression Err2 = Expression(0, 0, 0, 41);
}
