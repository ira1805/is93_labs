#include "LongList.h"

LongList::LongList() {
    this->head = nullptr;
    this->tail = nullptr;
}

void LongList::Add(long data) {
    this->count++;
    LongNode *node = new LongNode(data);
    if (this->head == nullptr){
        this->head = node;
    } else {
        this->tail->next = node;
        node->previous = this->tail;
    }
    this->tail = node;
}

void LongList::Delete(long data) {
    LongNode *current = this->head;
    while(current != nullptr){
        if (current->value == data) { break; }  // Find node with user's element
        current = current->next;  // Go to the next node
    }
    if (current != nullptr){
        if (current->next != nullptr){ // Check if current isn't last
            current->next->previous = current->previous;  // Previous node for next node will be previous node for current node
        } else {
            this->tail = current->previous;  // Previous node for current node will be a tail
        }
        if (current->previous != nullptr){
            current->previous->next = current->next;  // Next node for previous node will be next node for current node
        } else{
            this->head = current->next;  // Next node for current node will be a head
        }
        this->count--;  // if we found element in our structure
    } else {
        throw "There is no element in this structure"; // if we didn't find element in our structure
    }
}
int LongList::GetPosition(long element) {
    int position = 0;
    if (this->head->value == element){
        return position;  // Position of head is 0
    } else if (this->tail->value == element){
        return this->count;  // Position of tail = count - 1
    } else {
        LongNode *current = this->head;
        while (current != nullptr){  // Find element using iteration through structure
            if (current->value == element) { return position; }
            current = current->next;  // Go to the next node
            position++;
        }
    }
    throw "There is no element in this structure";  // if we didn't find element in our structure
}

int LongList::FindSpecialElements() {
    int amount = 0;
    LongNode *current = this->head;
    while (current != nullptr){  // Iterate through the structure
        try {
            // Check special conditions from the task
            if (current->value % 5 == 0 && GetPosition(current->value) % 2 == 0) { amount++; }
        } catch (const char*) {  // Catch exception if there are no special elements in the structure
            return 0;
        }
        current = current->next;  // Go to the next node
    }
    return amount;
}

void LongList::DeleteGreaterAvg() {
    long average = 0;
    LongNode *current = this->head;
    while (current != nullptr){  // Iterate through structure to calculate sum of all nodes
        average += current->value;
        current = current->next;
    }
    average /= this->count;  // Find average
    current = this->head;
    while (current != nullptr){  // Iterate through structure to find elements greater than average value and delete them
        if (current->value > average) { Delete(current->value); }
        current = current->next;
    }

}





