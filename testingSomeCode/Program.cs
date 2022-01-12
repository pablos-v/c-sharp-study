// find min index in sorted array with binary search

// int[] array = { 3, 4, 5, 6, 7, 8, 9, 0, 1, 2 };

// int FindMinIndex(int[] arr)
// {
//     int left = 0, right = arr.Length - 1, mid = -1;
//     while (Math.Abs(left - right) != 1)
//     {
//         mid = (right + left) / 2;
//         if (arr[left] < arr[right]) right = mid;
//         else left = mid;
//     }
//     if (mid == left) return right;
//     else return left;
// }

// Console.Write(FindMinIndex(array));


// write Mario tower from CS50

// void Mario()
// {
//     int n = 0;
//     while (n <= 0)
//     {
//         Console.WriteLine("Введите высоту блоков: ");
//         if (int.TryParse(Console.ReadLine(), out int m)) n = m;
//     }
//     for (int f = 1; f < n + 1; f++)
//     {
//         for (int i = 0; i < n - f; i++) Console.Write(" ");
//         for (int i = 0; i < f; i++) Console.Write("#");
//         Console.Write("\n");
//     }
// }

// Mario();

