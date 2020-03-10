#include <stdio.h>
#include <stdlib.h>

struct Node
{
	int data;
	struct Node* next;
};

void insertAtBegin(int);
void insertAtEnd(int);
void traverse();
void deleteFromBegin();
void deleteFromEnd();

struct Node* start = NULL;
int numberOfElements = 0;

int main()
{
	int i, data;

	for (;;)
	{
		printf("1. Insert an element at the beginning of linked list.\n");
		printf("2. Insert an element at the end of linked list.\n");
		printf("3. Traverse linked list.\n");
		printf("4. Delete an element from beginning.\n");
		printf("5. Delete an element from end.\n");
		printf("6. Exit\n");

		scanf("%d", &i);

		if (i == 1)
		{
			printf("Enter value of element\n");
			scanf("%d", &data);
			insertAtBegin(data);
		}
		else if (i == 2)
		{
			printf("Enter value of element\n");
			scanf("%d", &data);
			insertAtEnd(data);
		}
		else if (i == 3)
		{
			traverse();
		}
		else if (i == 4)
		{
			deleteFromBegin();
		}
		else if (i == 5)
		{
			deleteFromEnd();
		}
		else if (i == 6)
		{
			printf("You have successfully closed the program.");
			break;
		}
		else
		{
			printf("Please enter valid input.\n");
		}
	}

	return 0;
}

void insertAtBegin(int element)
{
	struct Node* t;

	t = (struct Node*)malloc(sizeof(struct Node));
	t->data = element;
	numberOfElements++;

	if (start == NULL)
	{
		start = t;
		start->next = NULL;
		return;
	}

	t->next = start;
	start = t;
}

void insertAtEnd(int element)
{
	struct Node* t, * temp;

	t = (struct Node*)malloc(sizeof(struct Node));
	t->data = element;
	numberOfElements++;

	if (start == NULL)
	{
		start = t;
		start->next = NULL;
		return;
	}

	temp = start;

	while (temp->next != NULL)
	{
		temp = temp->next;
	}

	temp->next = t;
	t->next = NULL;
}

void traverse()
{
	struct Node *t;

	t = start;

	if (t == NULL) 
	{
		printf("Linked list is empty.\n");
		return;
	}

	printf("There are %d elements in linked list.\n", numberOfElements);

	while (t->next != NULL) 
	{
		printf("%d\n", t->data);
		t = t->next;
	}

	printf("%d\n", t->data); // Print last node
}

void deleteFromBegin()
{
	struct Node *t;
	int n;

	if (start == NULL) 
	{
		printf("Linked list is empty.\n");
		return;
	}

	n = start->data;
	t = start->next;
	free(start);
	start = t;
	numberOfElements--;

	printf("%d deleted from the beginning successfully.\n", n);
}

void deleteFromEnd()
{
	struct Node *t;
	struct Node *u = NULL;
	int n;

	if (start == NULL) 
	{
		printf("Linked list is empty.\n");
		return;
	}

	numberOfElements--;

	if (start->next == NULL) 
	{
		n = start->data;
		free(start);
		start = NULL;
		printf("%d deleted from end successfully.\n", n);
		return;
	}

	t = start;

	while (t->next != NULL) 
	{
		u = t;
		t = t->next;
	}

	n = t->data;
	u->next = NULL;
	free(t);

	printf("%d deleted from end successfully.\n", n);
}