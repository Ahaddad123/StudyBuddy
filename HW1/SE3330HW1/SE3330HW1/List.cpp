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
	Node* temp;
	temp = head;
	head = new Node(item);
	head->next = temp;
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

	Node* temp = new Node(item);
	tail = temp;

}

int List::Find(int goal) 
{
	int index = 0;
	Node* temp = head;
	while (temp != nullptr) {
		if (temp->value = goal) 
		{
			return index;
		}
	}

	return -1;
}

int List::GetTail()
{
	return tail->value;
}

int List::GetHead()
{
	return head->value;
}