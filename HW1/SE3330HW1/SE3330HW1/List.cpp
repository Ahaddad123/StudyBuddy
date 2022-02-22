#include "List.h"

List::List() 
{
	head = nullptr;
}

bool List::IsEmpty() 
{
	bool result;
	if (head == nullptr)
		result = true;
	else
		result = false;
	return result;
}

void List::AddToHead(int item)
{
	head = new Node(item);
}

int List::Length()
{
	int length = 0;
	Node* temp = head;
	if (head != nullptr)
	{
		length++;
		while (head->next != nullptr)
		{
			temp = head->next;
			length++;
		}
	}
	return length;
}

void List::AddToTail(int item)
{

}

int List::GetTail()
{
	return tail->value;
}