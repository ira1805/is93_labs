#ifndef LABA8_LONGLIST_H
#define LABA8_LONGLIST_H

class LongList {
private:
    struct LongNode{
        long value;
        struct LongNode *previous;
        struct LongNode *next;
        LongNode(long data){
            this->value = data;
            this->previous = nullptr;
            this->next = nullptr;
        }
    };
    struct LongNode *head;  // First element of the structure
    struct LongNode *tail;  // Last element of the structure
    int count;  // Amount of elements in the structure
public:
    LongList();
    void Add(long data);
    void Delete(long data);
    int GetPosition(long element);
    int FindSpecialElements();
    void DeleteGreaterAvg();
};

#endif //LABA8_LONGLIST_H
