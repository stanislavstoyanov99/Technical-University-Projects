import math
import multiprocessing
import threading

# Създава се обект barrier, като му се задача брой нишки, които да се изчакват.
barrier = threading.Barrier(5)

data = [1 for _ in range(4000005)]
partial_sum = [0, 0, 0, 0]

number_of_cpus = multiprocessing.cpu_count()


def task1():
    name = threading.current_thread().name
    # print(f"Hello from thread {name}")

    thread_index = int(name)
    size = len(data)
    for i in range(thread_index, size, number_of_cpus):
        partial_sum[thread_index] = partial_sum[thread_index] + data[i]
    # Не продължава нататък, докато всички нищки не стигнат до тук.
    barrier.wait()


if __name__ == "__main__":

    for i in range(number_of_cpus):
        thread_name = f'{i}'
        thread_name = threading.Thread(target=task1, name=thread_name)
        thread_name.start()

    # Изчаква всички нишки да стигнат до wait
    barrier.wait()

    print(sum(partial_sum))
