#include<math.h>//for sqrt and pow
class Figures
{
      protected:double x1, y1, x2, y2, x3, y3, x4, y4;//koordinates
      public: double Line_1, Line_2, Line_3, Line_4;//Lines
    Figures(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)//Конструктор з параметрами
      {
          this->x1 = x1;
          this->y1 = y1;
          this->x2 = x2;
          this->y2 = y2;
          this->x3 = x3;
          this->y3 = y3;
          this->x4 = x4;
          this->y4 = y4;
          Length();
      }
private: void Length()// Method для знаходження довжини
{
    Line_1 = sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2));//Line a
    Line_2 = sqrt(pow(x4 - x3, 2) + pow(y4 - y3, 2));//Line b
    Line_3 = sqrt(pow(x1 - x4, 2) + pow(y1 - y4, 2));//Line c
    Line_4 = sqrt(pow(x2 - x3, 2) + pow(y2 - y3, 2));//Line d
}
};
class Trepeze :public Figures//Похідний клас від класу Figures
{
private:    double perimetr = 0;//Perimeter
            double square = 0;//Area
public:
    Trepeze(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4) :Figures(x1, y1, x2, y2, x3, y3, x4, y4)//Designer with parametrs
    {
        Perimetr(Line_1, Line_2,Line_3,Line_4);
        Square(Line_1, Line_2,Line_3, Line_4);
    }
private: void Perimetr(double a, double b, double c, double d)//Method Perimetr
{
           perimetr = a + b + c + d;
}
        void Square(double a, double b,double c, double d)//Method Square
       {
           square = ((a+b)/2)*sqrt(pow(c,2)-(pow(a-b,2)+pow(c,2)-pow(d,2)/(2*(a-b))));
       }
public: double Get_Perimetr()// Method for getting perimetr
{
          return perimetr;
}
         double Get_Square()// Method for getting square
      {
          return square;
      }
};
