#include <stdio.h>
#include <string.h>
#include <stdlib.h>

#define MAXLEN 3

void bubbleSort(char* arr[][MAXLEN], int length)
{
	char temp[MAXLEN];

	// Sorting strings using bubble sort 
	// I do not know why it is not working
	for (int j = 0; j < length - 1; j++)
	{
		for (int i = j + 1; i < length; i++)
		{
			if (strcmp(arr[j], arr[i]) > 0)
			{
				strcpy(temp, arr[j]);
				strcpy(arr[j], arr[i]);
				strcpy(arr[i], temp);
			}
		}
	}
}

int main()
{
	int numberOfLines;

	printf("Input number of strings:");
	scanf("%d", &numberOfLines);

	char* str[3];

	printf("Input string %d :\n", numberOfLines);
	for (int i = 0; i < numberOfLines; i++)
	{
		str[i] = malloc(50 * sizeof(char)); // allocates 50 bytes
		scanf("%99s", str[i]); // Use %99s to avoid overflow; No need to include & address, since word[i] is already a char* pointer
	}

	int length = sizeof(str) / sizeof(str[0]);

	bubbleSort(str, length);

	printf("Strings in sorted order are:");
	for (int i = 0; i < length; i++)
	{
		printf("\n Line %d is %s \n", i + 1, str[i]);
	}

	// Free allocated memory
	for (int i = 0; i < numberOfLines; i++) 
	{
		free(str[i]);
		str[i] = NULL;
	}

	system("pause");
	return 0;
}