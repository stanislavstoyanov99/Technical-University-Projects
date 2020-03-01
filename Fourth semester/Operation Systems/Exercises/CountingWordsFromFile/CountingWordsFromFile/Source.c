#include<stdio.h>

#define FILE_NAME "file.txt"

int main()
{
	int count = countWordsInFile(FILE_NAME);
	printf("Words count = %d\n", count);

	system("pause");
	return 0;
}

int countWordsInFile(const char* nameOfFile)
{
	FILE* file;
	int count = 1;
	char symbol;
	file = fopen(nameOfFile, "r");

	if (file == NULL)
	{
		printf("File not found\n");
		return 0;
	}

	while ((symbol = fgetc(file)) != EOF)
	{
		if (symbol == ' ' || symbol == '\n')
		{
			count++;
		}
	}

	fclose(file);
	return count;
}