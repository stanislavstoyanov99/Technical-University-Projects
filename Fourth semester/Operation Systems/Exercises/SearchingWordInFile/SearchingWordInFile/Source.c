#include<stdio.h>
#include<ctype.h>
#include<stdlib.h>
#include<string.h>

int searchInFile(char* fileName, char* stringToSearchFor)
{
	FILE* file;
	int lineNumber = 1;
	int find_result = 0;
	char temp[512];

	// If we cannot open the file
	if ((fopen_s(&file, fileName, "r")) != NULL)
	{
		return -1;
	}

	while (fgets(temp, 512, file) != NULL) 
	{
		for (int i = 0; stringToSearchFor[i], temp[i]; i++)
		{
			stringToSearchFor[i] = tolower(stringToSearchFor[i]);
			temp[i] = tolower(temp[i]);
		}

		if ((strstr(temp, stringToSearchFor) != NULL))
		{
			printf("A match found on line: %d", lineNumber);
			printf("\n----- %s\n", temp);
			find_result++;
		}

		lineNumber++;
	}

	if (find_result == 0) 
	{
		printf("Sorry, couldn't find a match.\n");
	}

	//Close the file if still open.
	if (file) 
	{
		fclose(file);
	}

	return 0;
}

int main()
{
	int result, errno;

	printf("Enter file name: ");
	char* fileName = malloc(5 * sizeof(char));
	scanf("%99s", fileName);

	printf("Enter string to search for: ");
	char* stringToSearchFor = malloc(5 * sizeof(char));
	scanf("%99s", stringToSearchFor);

	result = searchInFile(fileName, stringToSearchFor);
	if (result == -1)
	{
		perror("Error");
		printf("Error number = %d\n", errno);
		exit(1);
	}

	system("pause");
	return 0;
}