

//TASK - A

//void FindHighNumber(int[] array, int limit)
//{
//    for (int i = 0; i < array.Length; i++) n
//    {
//        if (array[i] > limit) n total n ^ 2 = 0(n)
//        {
//            Console.WriteLine(array[i]); 2n
//        }

//    }
//}
//int limit = 10;
//int[] array = { 2, 9, 45, 150 };
//FindHighNumber(array, limit);








//TASK - B


//int[] arr = { 4, 5, 9, 7, 5, 5 };
//int number = 5;

//int FindCount(int[] arr, int number)
//{
//    int count = 0;
//    for (int i = 0; i < arr.Length; i++)        // n
//    {                                                        //  total 2n= o(n)
//        if (arr[i] == number)                  //  n
//        {
//            count++;
//        }

//    }
//    return count;
//}

//int result = FindCount(arr, number);
//Console.WriteLine(result);


//TASK - C

//int[] ChangeNumbbers(int[] number)
//{
//    for (int i = 0; i < number.Length - 1; i += 2)     ////n
//    {
//        int temp = number[i];
//        number[i] = number[i + 1];
//        number[i + 1] = temp;

//    }
//    return number;

//}

//int[] result = ChangeNumbbers(new int[] { 1, 2, 3, 4, 5 });        // n


//for (int i = 0; i < result.Length; i++)                            //n       total = o(n^2)
//{
//    Console.WriteLine(result[i]);                                // n
//}




