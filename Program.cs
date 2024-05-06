#region  Task 1
//Params Keyworddən istifadə edərək aşağıda verilmiş metoda əsasən ədədlərin cəmini ekrana çıxarın.
//SumNumbers(10, 22, 36, 23, 65,13,15,18)

//Console.WriteLine(SumNumbers(10, 22, 36, 23, 65, 13, 15, 18));
//int SumNumbers(params int[] arr)
//{
//    int sum = 0;
//    foreach (int item in arr)

//    {
//        sum += item;
//    }
//    return sum;
//}
#endregion


#region Task2
//Ən böyük ədədlə ən kiçik ədədin hasilini aşağıda verilənlərə əsasən ekrana çıxarın.
//(Params Keyworddən istifadə edilməlidir).
//(36, 30, 5, 80, 20, 44, 12, 65, 51, 83);






#endregion


#region Task3
//İstifadəçi tərəfindən array uzunluğu təyin edib ədədləri sondan əvvələ doğru sıralayın.
//int[] a = new int[10];
//for (int i = 10; i >= 1; i--)
//{
//    Console.WriteLine(i);
//}




#endregion


#region Task4
//Verilmiş array - də bir ədədin neçə dəfə istifadə olduğunu tapıb ekrana çıxarın.
//Məsələn 7 ədədi array-də 3 ədəddir.
//{11, 26, 51, 69, 82,7, 15, 59, 95, 97,25,7, 37, 48, 57,26, 83,95,52,64,7,26};

//int[] numbers= { 11, 26, 51, 69, 82, 7, 15, 59, 95, 97, 25, 7, 37, 48, 57, 26, 83, 95, 52, 64, 7, 26 };
//int result = 0;
//int num;
//Console.Write("Enter a number:  ");
//int number=int.Parse(Console.ReadLine());
//for(int i = 0 ; i < numbers.Length ; i++)
//{
//    if(number == numbers[i])
//    {
//        result++;
//    }
//}
//if(result==0)
//{
//    Console.WriteLine("not found" );
//}
//else
//{
//    Console.WriteLine("found" );
//    Console.WriteLine("num: " + result);
//}

#endregion


#region Task5
//Array.IndexOf metodundan istifadə edərək verilmiş arraydə bir tələbənin mövcud olub olmadığını yazın.
//Əgər movcuddursa, "Tələbə tapıldı" əks halda "Tələbə tapılmadı" yazısını ekrana çıxarın.
//{"Ali","Nicat","Alim","Davud","Lale","Elchin","Faiq","Elvin"};


//Array names = new[] { "Ali", "Nicat", "Alim", "Davud", "Lale", "Elchin", "Faiq", "Elvin" };
//int index = Array.IndexOf(names, "Lale");
//if (index != -1)
//{
//    Console.WriteLine("Telebe tapildi");

//    if (index != -1)
//    {
//     int i= Array.IndexOf(names, "Lale", 0,3);
//       Console.WriteLine("Telebe tapilmadi");
//   }

//    }




#endregion

#region Task6
//CompareTo metodundan istifadə edərək istifadəçi tərəfindən verilmiş iki string-i müqayisə edin.

//string name1 = "Naila";
//string name2 = "Lala";
//int result=name1.CompareTo(name2);
//Console.WriteLine(result);
//Console.ReadLine();
#endregion


#region Task7
//Contains metodu ilə verilmiş string-də "age" sözünü axtarın.
//Tapılsa true, tapılmasa false qaytarsın.
//string message =  "C# is the most popular language in the world"


//string message = "C# is the most popular language in the world";

//bool result = message.Contains("age");

//Console.WriteLine(result);


#endregion

#region Task8
//Verilmiş array - də 1 - ci indekslə 3-cü indeks arasındakı sözləri birləşdirib ekrana çıxarın.
//(string join istifadə edilməlidir)
//string[] colors = { "white", "black", "green", "red", "yellow" };

//using static System.Net.Mime.MediaTypeNames;

//string[] colors = { "white", "black", "green", "red", "yellow" };
//Console.WriteLine(String.Join("green", colors));



#endregion