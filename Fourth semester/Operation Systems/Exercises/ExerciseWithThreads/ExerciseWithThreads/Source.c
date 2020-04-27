#include<stdio.h>
#define HAVE_STRUCT_TIMESPEC
#include<pthread.h>

int data = 1;

pthread_mutex_t lock;
pthread_cond_t cond;

void* EvenNumbers(void* tid)
{
    while (data < 11)
    {
        pthread_mutex_lock(&lock);
        if (data % 2 == 0)
        {
            printf("th2:%d\n", data++);
            pthread_cond_signal(&cond);
        }
        else
        {
            pthread_cond_wait(&cond, &lock);
        }

        pthread_mutex_unlock(&lock);
    }

    pthread_exit(&data);
}

void* OddNumbers()
{
    while (data < 11)
    {
        pthread_mutex_lock(&lock);
        if (data % 2 != 0)
        {
            printf("th1:%d\n", data++);
            pthread_cond_signal(&cond);
        }
        else
        {
            pthread_cond_wait(&cond, &lock);
        }

        pthread_mutex_unlock(&lock);
    }

    pthread_exit(&data);
}

int main()
{
    pthread_mutex_init(&lock, NULL);
    pthread_cond_init(&cond, NULL);

    pthread_t tid[2];

    pthread_create(&tid[0], NULL, EvenNumbers, (void*)&tid[0]);
    pthread_create(&tid[1], NULL, OddNumbers, (void*)&tid[1]);

    void* ret[2];

    pthread_join(tid[0], &ret[0]);
    pthread_join(tid[1], &ret[1]);

    return 0;
}