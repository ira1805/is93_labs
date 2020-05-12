#include <iostream>

using namespace std;

// Функція для порівняння значень масиву
bool matrix_comparitor(int A[], int B[], int i) {
    return A[i] == B[i];
}

int main()
{
    setlocale(LC_ALL, "Ukrainian");
    cout << "Стеблянко Олександр, Лабораторна 6, Завдання 9 \n \n";

    // Вказівник на функцію
    bool (*comp)(int *, int *, int);
    comp = &matrix_comparitor;

    int A[4] = { 4, 6, 8, 1 };
    int B[5] = { 2, 9, 8, 2, 5 };
    
    // Виклик вказівника    
    cout << "Порiвнюємо 8 та 8: ";
    cout << comp(A, B, 2) << "\n";
    cout << "Порiвнюємо 1 та 2: ";
    cout << comp(A, B, 3);
}
