/* C Program - Encrypt Files */
#include <string.h>
#include<stdio.h>
#include<stdlib.h>

int decrypt()
{
	char ch, choice, fname[20];
	FILE* fps, * fpt;
	printf("\nEnter file name (with extension like file.txt) which you have encrypted earlier to decrypt : ");
	fgets(fname, 20, stdin);
	strtok(fname, "\n");
	fps = fopen(fname, "w");
	if (fps == NULL)
	{
		printf("Error in opening source file..!!");
		printf("\nPress any key to exit...");
		exit(7);
	}

	fpt = fopen("temp.txt", "r");
	if (fpt == NULL)
	{
		printf("Error in opening temp.txt file..!!");
		fclose(fps);
		printf("\nPress any key to exit...");
		exit(9);
	}

	while (1)
	{
		ch = fgetc(fpt);

		if (ch == EOF)
		{
			break;
		}
		else
		{
			ch = ch - 100;
			fputc(ch, fps);
		}
	}

	printf("File %s decrypted successfully..!!", fname);
	printf("\nPress any key to exit...");
	fclose(fps);
	fclose(fpt);

	return 0;
}

int main()
{
	char fname[20], ch, choice;
	FILE* fps, * fpt;
	printf("Enter file name (with extension like file.txt) to encrypt : ");
	fgets(fname, 20, stdin);
	strtok(fname, "\n");
	fps = fopen(fname, "r");
	if (fps == NULL)
	{
		printf("Error in opening file..!!");
		printf("\nPress any key to exit...");
		exit(1);
	}

	fpt = fopen("temp.txt", "w");
	if (fpt == NULL)
	{
		printf("Error in creating temp.txt file..!!");
		fclose(fps);
		printf("\nPress any key to exit...");
		exit(2);
	}

	while (1)
	{
		ch = fgetc(fps);
		if (ch == EOF)
		{
			break;
		}
		else
		{
			ch = ch + 100;
			fputc(ch, fpt);
		}
	}

	fclose(fps);
	fclose(fpt);
	fps = fopen(fname, "w");
	if (fps == NULL)
	{
		printf("Error in opening source file..!!");
		printf("\nPress any key to exit...");
		exit(3);
	}

	fpt = fopen("temp.txt", "r");
	if (fpt == NULL)
	{
		printf("Error in opening temp.txt file...!!");
		fclose(fps);
		printf("\nPress any key to exit...");
		exit(4);
	}

	while (1)
	{
		ch = fgetc(fpt);
		if (ch == EOF)
		{
			break;
		}
		else
		{
			fputc(ch, fps);
		}
	}

	printf("File %s encrypted successfully..!!", fname);
	printf("\nPress any key to exit...");
	fclose(fps);
	fclose(fpt);

	decrypt();
	return 0;
}