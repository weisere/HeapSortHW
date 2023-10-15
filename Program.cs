// See https://aka.ms/new-console-template for more information

static void heapSort(int[] arr)
{
    int n = arr.Length; // Get the length of the array
    for (int i = n / 2 - 1; i >= 0; i--)
        heapify(arr, n, i);
    for (int i = n - 1; i >= 0; i--)
    {
        int temp = arr[0];
        arr[0] = arr[i];
        arr[i] = temp;
        heapify(arr, i, 0);
    }
}

static void heapify(int[] arr, int n, int i)
{
    int largest = i;
    int left = 2 * i + 1;
    int right = 2 * i + 2;
    if (left < n && arr[left] > arr[largest])
        largest = left;
    if (right < n && arr[right] > arr[largest])
        largest = right;
    if (largest != i)
    {
        int swap = arr[i];
        arr[i] = arr[largest];
        arr[largest] = swap;
        heapify(arr, n, largest);
    }
}

int[] arr = { 68, 75, 42, 61, 13, 5, 8, 12, 88, 90 };

Console.Write("array");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
heapSort(arr);
Console.Write("\nSorted");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}



