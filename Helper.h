#include<string>
#include<vector>
namespace Laba_4
{
    class Helper
    {
    public:int length;//довжина
    private: std::vector<char> str;//рядок
    public:Helper();
    public:Helper(std::vector<char> str);
    public:Helper(Helper&);
    private: void Initializ();//за замовчуванням
    private: void Str_Length(std::vector<char> str);//Для отримання довжини
    public:std::vector<char> Get_str();//Для отримання рядка
    public:Helper operator +(Helper right_val);//оператор додавання
    public:Helper operator *(int b);//оператор множення
    };
}