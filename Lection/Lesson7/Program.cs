﻿// string text = "О чем шумите вы, народные витии?"
// +"Зачем анафемой грозите вы России?"
// +"Что возмутило вас? волнения Литвы"
// +"Оставьте: это спор славян между собою,"
// +"Домашний, старый спор, уж взвешенный судьбою,"
// +"Вопрос, которого не разрешите вы."

// +"Уже давно между собою"
// +"Враждуют эти племена;"
// +"Не раз клонилась под грозою"
// +"То их, то наша сторона."
// +"Кто устоит в неравном споре:"
// +"Кичливый лях, иль верный росс?"
// +"Славянские ль ручьи сольются в русском море?"
// +"Оно ль иссякнет? вот вопрос."

// +"Оставьте нас: вы не читали"
// +"Сии кровавые скрижали;"
// +"Вам непонятна, вам чужда"
// +"Сия семейная вражда;"
// +"Для вас безмолвны Кремль и Прага;"
// +"Бессмысленно прельщает вас"
// +"Борьбы отчаянной отвага —"
// +"И ненавидите вы нас…"

// +"За что ж? ответствуйте: за то ли,"
// +"Что на развалинах пылающей Москвы"
// +"Мы не признали наглой воли"
// +"Того, под кем дрожали вы?"
// +"За то ль, что в бездну повалили"
// +"Мы тяготеющий над царствами кумир"
// +"И нашей кровью искупили"
// +"Европы вольность, честь и мир?.."

// +"Вы грозны на словах — попробуйте на деле!"
// +"Иль старый богатырь, покойный на постеле,"
// +"Не в силах завинтить свой измаильский штык?"
// +"Иль русского царя уже бессильно слово?"
// +"Иль нам с Европой спорить ново?"
// +"Иль русский от побед отвык?"
// +"Иль мало нас? Или от Перми до Тавриды,"
// +"От финских хладных скал до пламенной Колхиды,"
// +"От потрясенного Кремля"
// +"До стен недвижного Китая,"
// +"Стальной щетиною сверкая,"
// +"Не встанет русская земля?.."
// +"Так высылайте ж к нам, витии,"
// +"Своих озлобленных сынов:"
// +"Есть место им в полях России,"
// +"Среди нечуждых им гробов.";

// string Stix(string text, char staraya, char novaya)
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == staraya) result += $"{novaya}";
//         else result += $"{text[i]}";
//     }
//     return result;
// }    
// string newText = Stix(text, ' ', '|');
// System.Console.WriteLine(newText);

// int n = new Random().Next(10);
// int[] arr = new int[n];
// Random rnd = new Random();
int[] arr = {1, 3 ,43, 5, 534, 1, 1, 0};
void NewArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        // arr[i] = rnd.Next(10);
        System.Console.Write(array[i] + " ");
    }
        System.Console.WriteLine();
}

void Sortirovka(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[min]) min = j;
        }
        int N = array[i];
        array[i] = array[min];
        array[min] = N;

    }
}
NewArray(arr);
Sortirovka(arr);
NewArray(arr);