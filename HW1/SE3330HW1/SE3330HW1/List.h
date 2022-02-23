#pragma once
class List
{
private:
	struct Node
	{
		int value;
		Node* next;
		Node* previous;

		Node(int newValue)
		{
			value = newValue;
			next = nullptr;
			previous = nullptr;
		}
	};
	Node* head;
	Node* tail;

public:
	List();
	bool IsEmpty();
	void AddToHead(int item);
	int Length();
	void AddToTail(int item);
	int GetTail();
	int GetHead();
};

