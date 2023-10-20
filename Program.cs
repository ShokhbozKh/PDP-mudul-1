using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1dars
            #region 1
            // visual studio urnatish
            #endregion
            #region 2
            //Console.WriteLine("Hello, World!");
            #endregion
            #endregion

            #region 2dars
            #region 1
            //int a=5, b=6, c = 8;
            //Console.WriteLine("urta arfiometik:" + (a+b+c)/3;
            #endregion
            #region 2
            //Console.Write("a:");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b=");
            //int b = int.Parse(Console.ReadLine());
            //int peremetr = 2 * (a + b);
            //int yuzi = a * b;
            //Console.WriteLine("p="+peremetr);
            //Console.WriteLine("s=" + yuzi);
            #endregion
            #region 3
            //Console.Write("Aylana yuzi:");
            //float s=float.Parse(Console.ReadLine());
            //Console.WriteLine("radus:"+(Math.Sqrt(s/Math.PI)));
            //Console.WriteLine("Deametr:" + 2*(Math.Sqrt(s / Math.PI)));//d=2r;
            #endregion
            #endregion

            #region 3dars
            #region 1
            //Console.Write("int a:");
            //int a=int.Parse(Console.ReadLine());
            //Console.Write("double b:");
            //double b=double.Parse(Console.ReadLine());
            //int y = a + (int)b;// expiliset casting  kichik toifaga uzlashtirish
            //double z = a + b;// impiliset casting katta toifaga avtomatik uzlashadi
            //Console.WriteLine("int yig'indisi:" + y);
            //Console.WriteLine("Double yig'indi:" + z);
            #endregion
            #region 2
            //Console.Write("Float a:");
            //float a = float.Parse(Console.ReadLine());
            //Console.Write("Long b:");
            //double b = long.Parse(Console.ReadLine());
            //Console.WriteLine((a-b).GetType());
            //Console.WriteLine(a-b);// qaytarish toifasi double


            #endregion
            #region 3
            //Console.Write("Double toifasi a:");
            //double a=double.Parse(Console.ReadLine());
            //Console.WriteLine("long:"+((long)a));
            //Console.WriteLine("int:" + ((int)a));
            //Console.WriteLine("short:" + ((short)a));
            //Console.WriteLine("char:" + ((char)a));
            //Console.WriteLine("byte:" + ((byte)a));
            //Console.WriteLine("float:" + ((float)a));
            #endregion
            #region 4
            //Console.Write("Byte:");
            //byte a = byte.Parse(Console.ReadLine());
            //Console.Write("Char:");
            //char b = char.Parse(Console.ReadLine());
            //Console.Write("short:");
            //short c = short.Parse(Console.ReadLine());
            //Console.Write("int:");
            //int d = int.Parse(Console.ReadLine());
            //Console.Write("Float:");
            //float e = float.Parse(Console.ReadLine());
            //var result = a +b + c + d + e;
            //Console.WriteLine(result.GetType());
            //Console.WriteLine(result);// avtomatik kattasini toifasiga utadi System.Single bu float toifa
            ////https://technologies.gitbook.io/csharp/chapter-1-definitions/data-types-primitive-types


            #endregion
            #endregion

            #region 4dars
            #region 1
            //Console.Write("Son kiriting:");
            //string text = Console.ReadLine();
            //var result = Convert.ToDouble(text);//toifasini aniq berishimiz kerak
            //Console.WriteLine("NATIJA="+(result%5));
            #endregion
            #region 2
            //Console.Write("vaqt minutda:");
            //float t = float.Parse(Console.ReadLine());
            //Console.Write("Masofa kilometrda:");
            //decimal m = decimal.Parse(Console.ReadLine());
            //var result = ((float)(m)*1000) / ( (t)*60) ; //       m/s ->tezlik
            //Console.WriteLine("Natija: " + (result) + " m/s");// natija float type da chiqadi

            #endregion
            #region 3
            //Console.Write("a=");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b=");
            //int b = int.Parse(Console.ReadLine());
            ////2 3
            //a = a + b;
            //b = a - b;
            //a = a - b;
            //Console.WriteLine();
            //Console.WriteLine("a=" + a + "\nb=" + b);

            #endregion
            #region 4
            //Console.Write("a=");
            //int a = int.Parse(Console.ReadLine());

            //int a3 = a * a * a ; //a3
            //int a9 = a3 * a3 * a3;//a9
            //int a2 = a * a;

            //int a4 = a2 * a2;
            //int a6 = (a2 * a2) * a * a ;
            //int a15 = (a3 * a3 * a3) * (a2 * a2) * a;

            //Console.WriteLine($"a^4:{a4}");
            //Console.WriteLine($"a^6:{a6}");
            //Console.WriteLine($"a^15:{a15}");

            #endregion
            #region 5
            //Console.WriteLine("-----------kiritilgan sonni karra jadvali-----------");
            //Console.Write("Son kiriting:");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine($"1 x {n} = {1 * n}");
            //Console.WriteLine($"2 x {n} = {2 * n}");
            //Console.WriteLine($"3 x {n} = {3 * n}");
            //Console.WriteLine($"4 x {n} = {4 * n}");
            //Console.WriteLine($"5 x {n} = {5 * n}");
            //Console.WriteLine($"6 x {n} = {6 * n}");
            //Console.WriteLine($"7 x {n} = {7 * n}");
            //Console.WriteLine($"8 x {n} = {8 * n}");
            //Console.WriteLine($"9 x {n} = {9 * n}");
            //Console.WriteLine($"10 x {n} = {10 * n}");
            #endregion
            #region 6
            //Console.Write($" 4 xonali son kiriting:");
            //int a = int.Parse(Console.ReadLine());
            //int bir = (a / 1000);
            //int ikki = ((a / 100) % 10);
            //int uch = ((a / 10) % 10);
            //int turt = a * 10;
            //bool result = ((bir != ikki) && (bir != uch) && (bir != turt) && (ikki!=uch) && (ikki !=turt) && (uch !=turt));
            //Console.WriteLine(result);

            #endregion
            #endregion

            #region 5dars
            #region 1
            //Console.Write("a=");
            //int a = Convert.ToInt32(Console.ReadLine());

            //if(a == 0)
            //{
            //    Console.WriteLine("berilgan son oga teng");
            //}
            //else if (a > 0)
            //{
            //    //musnatligi aniq
            //    if(a % 2 == 0)
            //    {
            //        Console.WriteLine($"{a} musbat juft son");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{a} musbat toq son");
            //    }
            //}
            //else
            //{
            //    //manfiyligi aniq
            //    if(a % 2 == 0)
            //    {
            //        Console.WriteLine($"{a} manfiy juft son");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{a} manfiy toq son");
            //    }
            //}
            #endregion
            #region 2
            //Console.Write("Xafta kunini kiriting:");
            //int k = int.Parse(Console.ReadLine());

            //if (k == 1)
            //{
            //    Console.WriteLine("Dushanba");
            //}
            //else if (k == 2)
            //{
            //    Console.WriteLine("Seshanba");
            //}
            //else if(k == 3)
            //{
            //    Console.WriteLine("chorshanba");
            //}
            //else if(k == 4)
            //{
            //    Console.WriteLine("payshanba");
            //}
            //else if( k == 5)
            //{
            //    Console.WriteLine("juma");
            //}
            //else if(k == 6)
            //{
            //    Console.WriteLine("shanba");
            //}
            //else if(k==7)
            //{
            //    Console.WriteLine("yakshanba");
            //}
            //else
            //{
            //    Console.WriteLine("bunday xafta kuni yuq");
            //}
            #endregion
            #region 3
            //Console.Write("Operator kodini kiriting:");
            //string text = Console.ReadLine();
            // if (text == string.Empty)
            // {
            //    Console.WriteLine("Bush operator kodi");
            // }
            // else if(Convert.ToInt32(text)==90)
            // {
            //    Console.WriteLine($"{text} Belline");
            // }
            //else if (Convert.ToInt32(text) == 91)
            //{
            //    Console.WriteLine($"{text} Belline");
            //}
            //else if (Convert.ToInt32(text) == 93)
            //{
            //    Console.WriteLine($"{text} Ucell");
            //}
            //else if (Convert.ToInt32(text) == 94)
            //{
            //    Console.WriteLine($"{text} Ucell");
            //}
            //else if (Convert.ToInt32(text) == 97)
            //{
            //    Console.WriteLine($"{text} UMS");
            //}
            //else if (Convert.ToInt32(text) == 88)
            //{
            //    Console.WriteLine($"{text} UMS");
            //}
            // else 
            // { 
            //    Console.WriteLine("bunday operator kodi mavjud emas");
            // }
            #endregion
            #region 4
            ////dollar yevro yuan valuta konvertori
            //Console.WriteLine("Convertor");
            //Console.WriteLine("1.dollardan yevroga     2. dollarda yuanga");
            //Console.WriteLine("3.yevrodan dollarga     4.yevrodan yuanga");
            //Console.WriteLine("5.yuandan dollarga       6.yuandan yevroga");
            //Console.Write("Enter:");
            //int n  = int.Parse(Console.ReadLine());

            //if (n == 1)
            //{
            //    Console.Write("qancha mablag' almashtirish:");
            //    int d = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"{d*d} yevro ga teng");// shu asosida qilinadi boshqa yuli ham bor sodda

            //}
            //else if (n == 2)
            //{

            //}
            //else if(n == 3)
            //{

            //}
            //else if( n == 4)
            //{

            //}
            //else if(n==5)
            //{

            //}
            //else if(n==6)
            //{

            //}
            //else
            //{
            //    Console.WriteLine("bunday malumot yuq");
            //}
            //Main(args);
            #endregion
            #region 5
            //kabisa yili
            //Console.Write("yil kiriting:");
            //int n =int.Parse(Console.ReadLine());

            //Console.Clear();
            //if (n % 4 == 0)
            //{
            //    if (n % 100 == 0 && n % 400 == 0)
            //    {
            //        Console.WriteLine($"{n} kabisa yili");

            //    }
            //    if(n % 4 == 0 && n % 100 != 0)
            //    {
            //        Console.WriteLine($"{n} kabisa yili");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{n} kabisa emas");

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Kabisa yili emas");
            //}
            //Main(args);

            #endregion
            #region 6
            //Console.Write("Baho kiriting:");
            //int baho = int.Parse(Console.ReadLine());

            //switch(baho)
            //{
            //    case 1: Console.WriteLine("yomon"); break;
            //    case 2: Console.WriteLine("qoniqarsiz"); break;
            //    case 3: Console.WriteLine("qoniqarli"); break;
            //    case 4: Console.WriteLine("yaxshi"); break;
            //    case 5: Console.WriteLine("a'lo"); break;
            //    default: Console.WriteLine("bunday baho yuq"); break;
            //}
            #endregion
            #region 7
            //Console.Write("oy raqamini kiriting:");
            //int day = int.Parse(Console.ReadLine());

            //switch (day)
            //{
            //    case 1:    
            //    case 2://case 1, 2, 12 bulsa bitta 12 blok bajariladi
            //    case 12:
            //        Console.WriteLine("Qish");
            //        break;

            //    case 3:   
            //    case 4:
            //    case 5:
            //        Console.WriteLine("Bahor");
            //        break;

            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("Yoz");
            //        break;

            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("Kuz");
            //        break;

            //    default: Console.WriteLine("xato oy kiritildi");
            //        break;
            //}
            #endregion
            #region 8
            //Console.Write("Oy raqamini kiriting:");
            //int n = int.Parse(Console.ReadLine());

            //switch(n)
            //{
            //    case 12:
            //    case 3:
            //    case 1:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //        Console.WriteLine($"{n}-oyda 31 kun bor");
            //        break;

            //    case 2:
            //        Console.WriteLine($"{2}-oyda 28 yoki 29 kun bor"); 
            //        break;

            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine($"{n}-oyda 30 kun bor");
            //        break;

            //    default: Console.WriteLine("Xatolik bor"); break;
            //}

            #endregion
            #region 9
            //Console.Write("Birinchi son:");
            //int numberFirst=int.Parse(Console.ReadLine());
            //Console.Write("Amalni kiriting(+,-,*,/):");
            //char amal = char.Parse(Console.ReadLine());
            //Console.Write("Ikkinchi son:");
            //int numberSecond=int.Parse(Console.ReadLine());

            //switch (amal)
            //{
            //    case '+':
            //        Console.WriteLine($"{numberFirst} + {numberSecond} = {numberFirst + numberSecond}");
            //        break;
            //    case '-':
            //        Console.WriteLine($"{numberFirst} - {numberSecond} = {numberFirst - numberSecond}");
            //        break;
            //    case '*':
            //        Console.WriteLine($"{numberFirst} * {numberSecond} = {numberFirst * numberSecond}");
            //        break;
            //    case '/':
            //        Console.WriteLine($"{numberFirst} / {numberSecond} = {numberFirst / numberSecond}");
            //        break;
            //    default: Console.WriteLine("xato amal");
            //        break;

            //}


            #endregion
            #endregion

            #region 6dars
            #region 1
            //Console.Write("K=");
            //int k = int.Parse(Console.ReadLine());
            //Console.Write("N=");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(k + " ");
            //}

            #endregion
            #region 2
            //Console.Write("num1:");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("num2:");
            //int num2 = int.Parse(Console.ReadLine());
            //int sum = 0;

            //for(int i = num1+1; i < num2; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine($"Result:{sum}");
            #endregion
            #region 3
            //Console.Write("N butun son:");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 2; i < n; i++)
            //{
            //    if (i % 2 != 0)
            //        Console.WriteLine(i);
            //}

            #endregion
            #region 4
            //Console.Write("N butun sonni kirit:");
            //int n = int.Parse(Console.ReadLine());

            // for(int i = 2; i < n; i++)
            // {
            //    int counter = 0;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            counter++;
            //        }
            //    }
            //    if(counter == 2)
            //    {
            //        Console.WriteLine(i);
            //    }
            // }

            #endregion
            #region 5
            //Console.WriteLine("Raqamlari takrorlanmaydigan 3 xonali sonlar");

            //for(int i = 1; i <10; i++)
            //{
            //    for(int j = 0; j < 10; j++)
            //    {
            //        for(int k = 0; k < 10; k++)
            //        {
            //            if ((i != j) && (i != k) && (j != k))
            //            {
            //                Console.WriteLine($"{i}{j}{k}");
            //            }

            //        }
            //    }
            //}
            #endregion
            #region 6
            //Console.WriteLine("Raqamlari takrorlanmaydigan 3 xonali sonlar");

            //for (int i = 1; i < 10; i++)
            //{
            //    if (i == 5) break;
            //    for (int j = 0; j < 10; j++)
            //    {
            //        for (int k = 0; k < 10; k++)
            //        { 
            //            if ((i+j+k==15))
            //            {
            //                Console.WriteLine($"{i}{j}{k}");
            //            }

            //        }

            //    }
            //}
            #endregion
            #region 7
            //Console.WriteLine("Raqamlari takrorlanmaydigan 3 xonali sonlar");
            //string result1 = "";
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        for (int k = 0; k < 10; k++)
            //        {
            //            for(int l = 0; l < 10; l++)
            //            {
            //                result1 = $"{i}{j}{k}{l}";

            //                int result2 = Convert.ToInt32(result1);

            //                if (result2 / 47 == 43)
            //                {
            //                    Console.WriteLine(result2);
            //                }
            //                if(result2 / 43 == 40)
            //                {
            //                    Console.WriteLine(result2);
            //                }
            //            }
            //        }
            //    }
            //}
            #endregion
            #region 8
            //Console.WriteLine("Chang'ichi masalasi");
            //int s = 10;
            //int t = 1;
            //while (s<=100)
            //{
            //    s = s + s / 10;
            //    t++;
            //    if (s == 20)
            //    {
            //        Console.WriteLine($"{s} km {t}-kuni");
            //    }
            //    if (s >= 100)
            //    {
            //        Console.WriteLine($"{s} km {t}-kuni");
            //        break;
            //    }
            //}
            #endregion
            #region 9
            //for(int i=30; i<100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        if(i%10 == 2 || i%10 == 4 || i % 10 == 8)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            #endregion
            #region 10
            //Console.Write("N=");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("M=");
            //int m = int.Parse(Console.ReadLine());
            //int counter = 0;

            //while (n>m)
            //{
            //    n = n - m;
            //    counter++;
            //}
            //Console.WriteLine($"n / m -> {counter} butun {n} qoldiqga teng");
            #endregion
            #endregion

            #region 7dars
            #region 1
            //Console.Write("ixtiyoriy son kiriting:");// funksiyasi pastda
            //int n = int.Parse(Console.ReadLine());
            //int result = Pow3(n);
            //Console.WriteLine(result);

            #endregion
            #region 2
            //Console.Write("son kiriting ishorasini topamiz:");// method pastda
            //int n = int.Parse(Console.ReadLine());
            //char result = Ishora(n);
            //Console.WriteLine(result);
            //#endregion
            #region 3

            #endregion
            #region 4

            #endregion
            #region 5

            #endregion

            #endregion
            #region 3
            //Console.Write("Yil kirit men asr qaytaraman:");
            //int year = int.Parse(Console.ReadLine());
            //int result = Asr(year);// method pastda
            //Console.WriteLine(result + " asr");
            #endregion
            #region 4
            //Console.Write("Son kiriting:");
            //int n = int.Parse(Console.ReadLine());
            //int result = SonNechaXona(n);// method pastda
            //Console.WriteLine(result + " xonalik son");
            #endregion
            #region 5
            //Console.Write("x=");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("y=");
            //int y = int.Parse(Console.ReadLine());

            //MinAndMax(x: x, y: y);//method pastda

            #endregion
            #endregion 7


            #region 8dars
            #region 1
            //Console.Write("tug'ilgan yilingiz:");
            //int age = int.Parse(Console.ReadLine());
            //Biography(age);//method pastda

            #endregion
            #region 2
            //Console.Write("Matn kiriting:");
            //string text = Console.ReadLine();
            //string result = text.ToLower();//.ToUpper()  hammasini kattaga utkazadi
            //Console.WriteLine(result);
            #endregion
            #region 3
            //Console.Write("Text:");
            //string text = Console.ReadLine();// matn ustida kup amal bajarilda stringBuilder ishlatish kerak

            //string resultText = "";

            //for(int i = text.Length-1; i >= 0; i--)
            //{
            //    resultText += text[i];
            //}
            //Console.WriteLine(resultText);
            #endregion
            #region 4
            //Console.Write("enter text:");
            //string text = Console.ReadLine();

            //int result1= text.IndexOf(' ');
            //int result2= text.LastIndexOf(' ');

            //if(result1>0 && result2 > 0)
            //{
            //    Console.WriteLine(text.Substring(result1+1));
            //}
            //else
            //{
            //    Console.WriteLine(string.Empty);
            //}
            #endregion
            #region 5
            //Console.Write("matn1:");
            //string text1 = Console.ReadLine();
            //Console.Write("matn2:");
            //string text2= Console.ReadLine();
            //string result = NewText(text1, text2);// method pastda
            //Console.WriteLine(result);
            #endregion
            #region 6
            //Console.Write("matn1:");
            //string text1 = Console.ReadLine();
            //Console.Write("matn2:");
            //string text2 = Console.ReadLine();

            //string result = "";
            //if(text1[text1.Length-1] == text2[0])
            //{
            //    result=text1+text2.Substring(1);
            //}
            //else
            //{
            //    result=text1+text2;
            //}
            //Console.WriteLine(result);

            #endregion
            #region 7
            //Console.Write("Matn kiriting:");
            //string text = Console.ReadLine();
            //string result = "";
            //result = text.Substring(0, text.Length - 2) + text[text.Length-1] + text[text.Length-2];
            //Console.Write(result);

            #endregion
            #region 8
            //Console.Write("Matn s1:");
            //string s1 = Console.ReadLine();
            //Console.Write("Matn s2:");
            //string s2 = Console.ReadLine();
            //bool result = s1.Contains(s2);
            //Console.WriteLine(result);
            #endregion

            #endregion 8

            #region 9dars
            #region 1

            #endregion
            #region 2
            #endregion
            #region 3
            #endregion
            #region 4
            #endregion
            #region 5
            #endregion
            #region 6
            #endregion
            #region 7
            #endregion

            #endregion 9


            #region 10dars

            #endregion


        }
        //static int Pow3(int n)// 7 dars 1
        //{
        //    return n*n*n;
        //}
        //static char Ishora(int n)// 7 dars 2
        //{
        //    if (n > 0)
        //    {
        //        return '+';
        //    }
        //    return '-';
        //}
        //static int Asr(int yil)//7 dars 3
        //{
        //    return (yil / 100 + 1);
        //}

        //static int SonNechaXona(int n)// 7 dars 4
        //{
        //    int t = 1;
        //    while(n > 10)
        //    {
        //        n = n / 10;
        //        t++;
        //    }
        //    return t;
        //}
        //static void MinAndMax(int x, int y)// 7 dars 5
        //{
        //    if(x > y)
        //    {
        //        Console.WriteLine($"x={x}  y={y}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"x={y}  y={x}");
        //    }
        //}
        //static void Biography(int age)//8 dars 1
        //{
        //    Console.WriteLine("sizning yoshingiz: " + (DateTime.Now.Year - age) + " da");
        //}
        //static string NewText(string t1, string t2)// 8-dars 5
        //{
        //    string result = t1.Substring(1) + t2.Substring(1);
        //    return result;
        //}

    }
}