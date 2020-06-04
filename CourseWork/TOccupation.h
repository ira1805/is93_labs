#pragma once
#include <string>
#include <iostream>
#include "TTeacher.h"
#include "TGroup.h"
#include "TAudience.h"
#include "TDiscipline.h"
 
using namespace std;

class TOccupation
{
public:
    TOccupation();
    TOccupation(int new_id_teacher,
        int new_n_audience,
        int new_id_discipline,
        string new_occupation_topic,
        int new_id_occupation);

    void set_id_teacher(int new_id_teacher);
    void set_n_audience(int new_id_audience);
    void set_id_discipline(int new_id_discipline);
    void set_id_occupation(int new_id_occupation);
    void set_occupation_topic(string new_occupation_topic);

    int get_id_teacher(int id);
    int get_n_audience(int id);
    int get_id_disciline(int id);
    int get_id_occupation();
    string get_occupation_topic();

private:
    int id_teacher;
    int n_audience;
    int id_discipline;
    int id_occupation;
    string occupation_topic;
};
//---------------------------------------------------------