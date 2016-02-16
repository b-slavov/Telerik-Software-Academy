1. **What is the expected running time of the following C# code?**
```cs
long Compute(int[] arr)
{
    long count = 0;
    for (int i=0; i<arr.Length; i++)
    {
        int start = 0, end = arr.Length-1;
        while (start < end)
            if (arr[start] < arr[end])
                { start++; count++; }
            else 
                end--;
    }
    return count;
}
```
* Each iteration of the outer for loop causes *n* more iterations for the inner while loop. Getting an element by index or incrementing/decrementing variables is constant. So the expected running time is **O(n^2)**.

2. **What is the expected running time of the following C# code?**
```cs
long CalcCount(int[,] matrix)
{
    long count = 0;
    for (int row=0; row<matrix.GetLength(0); row++)
        if (matrix[row, 0] % 2 == 0)
            for (int col=0; col<matrix.GetLength(1); col++)
                if (matrix[row,col] > 0)
                    count++;
    return count;
}
```
* Best case: none of the memmbers from the first column are even and the inner for loop will not iterate. So the running time will be O(n).
* Worst case: every member from the first column is even and the inner loop will iterate *m* times per every *n* time for the rows. So the running time will be **O(n*m)**.

3. **(*) What is the expected running time of the following C# code?**
```cs
long CalcSum(int[,] matrix, int row)
{
    long sum = 0;
    for (int col = 0; col < matrix.GetLength(0); col++) 
        sum += matrix[row, col];
    if (row + 1 < matrix.GetLength(1)) 
        sum += CalcSum(matrix, row + 1);
    return sum;
}

Console.WriteLine(CalcSum(matrix, 0));
```
* Best case: CalcSum is called with row (row ∈ [*m - 1*; +∞)) as a second parameter. The for loop will run *n* times and the recursive call won't be reached. So the running time will be O(n).
* Worst case: CalcSum is called with zero as a second parameter. The for loop will run *n* times and the recursion will run in *m - 1* times. So the running time will be **O(n * m)**.