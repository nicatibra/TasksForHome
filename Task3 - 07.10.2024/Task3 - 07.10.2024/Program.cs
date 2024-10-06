#region ArrayMurekkebEdedPrint
// 1)Verilmish arrayda murekkeb ededleri ekrana çıxaran algorithm misal:input {5,9,12,11} output 9, 12

//Console.WriteLine("Composite numbers: ");
//int[] numbersArr = { 1, 2, 3, 4, 8, 11, 13, 15, 12, 21 };

//for (int i = 0; i < numbersArr.Length; i++)
//{
//    int count = 0;

//    for (int j = 1; j <= numbersArr[i]; j++)
//    {
//        if (numbersArr[i] % j == 0)
//        {
//            count++;
//        }
//    }

//    if (count > 2)
//    {
//        Console.WriteLine(numbersArr[i]);
//    }
//}

#endregion

#region arr1 = arr2
// 2) Ədədlərdən ibarət İki array verilib. Hər iki arrayda mövcud olan elementleri ekrana çıxaran  algorithm
//(Məsələn { 4,5,9,11,15} ve {1,5,13,15}   hər ikisində 5 və 15 var bunlar ekrana cixmalidir)

//int[] numsArr1 = { 2, 3, 4, 5, 6 };
//int[] numsArr2 = { 4, 5, 6, 7, 8 };

//Console.WriteLine("Both arrays have: ");
//for (int i = 0; i < numsArr1.Length; i++)
//{
//    for (int j = 0; j < numsArr2.Length; j++)
//    {
//        if (numsArr1[i] == numsArr2[j])
//        {
//            Console.WriteLine(numsArr1[i]);
//        }
//    }
//}

#endregion

#region IndexOfSmallestAndBiggest
// 3) Verilmish arrayin en boyuk ve en kicik elementlerinin indexlerini ekrana çıxaran  algorithm 
//misal: input { 2, 5, 1, 8, 10} output en kicik deyerin indexi 2, en boyuk deyerin indexi 4

//int[] numsArr = { 2, 1, 3, 8, 4, -6 };

//int smallest = numsArr[0];
//int smallestIndex = 0;

//int biggest = numsArr[0];
//int biggestIndex = 0;

//for (int i = 0; i < numsArr.Length; i++)
//{
//    if (numsArr[i] < smallest)
//    {
//        smallest = numsArr[i];
//        smallestIndex = i;
//    }

//    if (numsArr[i] > biggest)
//    {
//        biggest = numsArr[i];
//        biggestIndex = i;
//    }
//}
//Console.WriteLine("Index of smallest number: " + smallestIndex);
//Console.WriteLine("Index of biggest number: " + biggestIndex);

#endregion

#region Sum
//Verilmish ededin mertebelerinin cemini tapan  algorithm.

//Console.WriteLine("Enter the number:");
//int number = Convert.ToInt32(Console.ReadLine());
//int sum = 0;

//while (number != 0)
//{
//    sum += number % 10;
//    number /= 10;
//}
//Console.WriteLine("Sum = " + sum);

#endregion

#region OptionalTask
// 5) (optional) 1-den 10 qeder olan arrayda bir reqem eskikdir.
//Eskik olan reqemi tapan algorithm yazin ve nezere alin ki verilen arrayda reqemler siralanmadan duzulub
//misal: input {4, 1, 9, 6, 10, 2, 5, 8, 3} output 7

//int[] numsArr = { 4, 1, 9, 6, 10, 2, 5, 8, 3 };
//int sum = 0;
//for (int i = 0; i < numsArr.Length; i++)
//{
//    sum += numsArr[i];
//}
//Console.WriteLine(55 - sum);//1dən 10a qədər rəqəmlərin cəmi - arraydəki ədədlərin cəmi = çatmayan ədəd


//Və ya: -----------------------------------------------------------------------------------------------------


//User-inputed version:
//Kodumun izahı:
//Başlanğıc və son ədədi daxil edirik.
//Sonra o aralıqda elementləri daxil edərkən(Sırasız da daxil etmək olar) bir dənəsin buraxırıq.
//Məsələn: 1 və 5. Daxil olunan ədədlər: 2,1,4,5. (3 daxil edilmədi)
//Proqram 1dən 5ə qədər olan ədədlərin cəmin tapır, sonra isə ondan daxil edilən ədədlərin cəmin çıxır.

//Console.WriteLine("Enter starting point: ");
//int start = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter end point: ");
//int end = Convert.ToInt32(Console.ReadLine());

//int sizeOfArray = end - start;
//int[] numsArr = new int[sizeOfArray];

//Console.WriteLine("Enter numbers from " + start + " to " + end + " (miss one number): ");

//int sumOfArray = 0;

//for (int i = 0; i < sizeOfArray; i++)
//{
//    Console.WriteLine("Enter " + (i + 1) + " element of array:");
//    numsArr[i] = Convert.ToInt32(Console.ReadLine());
//    sumOfArray += numsArr[i];
//}

//int rangeSum = (start + end) * (end - start + 1) / 2; //Ədədi silsilə cəm düsturu: ((a1 + an)/2)*n

//Console.WriteLine("Your Array: ");
//for (int i = 0; i < sizeOfArray; i++)
//{
//    Console.WriteLine(numsArr[i]);
//}
//Console.WriteLine("Missed number: " + (rangeSum - sumOfArray));

#endregion


