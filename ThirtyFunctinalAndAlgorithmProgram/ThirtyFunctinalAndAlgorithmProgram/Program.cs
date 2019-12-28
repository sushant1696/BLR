using System;

namespace ThirtyFunctinalAndAlgorithmProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 for even number");
            Console.WriteLine("2 for binary search");
            Console.WriteLine("3 for primpalindrom");
            Console.WriteLine("4 for reverse a number");
            Console.WriteLine("5 for random number generation number");
            Console.WriteLine("6 for 2d array");
            Console.WriteLine("7 for coin flip");
            Console.WriteLine("8 for leap year");
            Console.WriteLine("9 for string equals or not");
            Console.WriteLine("10 for bubble sort");
            Console.WriteLine("11 for the anagram");
            Console.WriteLine("12 for power of two");
            Console.WriteLine("13 decimal to binary");
            Console.WriteLine("14 for dice rool");
            Console.WriteLine("15 for gambler");
            Console.WriteLine("16 for angstrom");
            Console.WriteLine("17 for coupon");
            Console.WriteLine("18for sum of three no zero");
            Console.WriteLine("19 for square root");
            Console.WriteLine("20 for the wind chill");
            Console.WriteLine("21 for the distance");
            Console.WriteLine("22 for the temperature");

            int a = int.Parse(Console.ReadLine());


            switch (a)
            {
                case 1:
                    even obj = new even();
                    obj.iseven();
                    break;
                case 2:
                    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                    int hi = arr.Length;
                    int x = Convert.ToInt32(Console.ReadLine());
                    BinerySearch obj1=new BinerySearch();
                    int result = obj1.isbinary(arr,0,hi-1,x);
                    Console.WriteLine("element is present at index", result);
                    break;
                case 3:
                    PrimePalindrom obj2 = new PrimePalindrom();
                    obj2.isprime();
                    break;

                case 4:
                    int n = 123;
                    ReverseANumber obj3 = new ReverseANumber();
                    obj3.isreverse(n);
                    break;
                case 5:
                    RandomNo obj5 = new RandomNo();
                    double sum=obj5.israndom(1,10);
                    Console.WriteLine("the generated random no is:"+sum);

                    break;
                case 6:
                    // TwoDArray obj6 = new TwoDArray();
                    TwoDArray.isarray();
                    break;
                case 7:
                    FlipCoin obj7 = new FlipCoin();
                    obj7.iscoin(100);
                    break;
                case 8:
                    LeapYear obj8 = new LeapYear();
                    obj8.isleap();
                    break;
                case 9:
                    EqualsString obj9 = new EqualsString();
                    obj9.isequal();
                    break;
                case 10:
                    // BubbleSort obj10 = new BubbleSort();
                    int[] array = { 9,8,6,4,87 };
                     n = array.Length;                
                BubbleSort.isbubble(array,n);
                    break;
                case 11:
                   
                    Anagram obj11 = new Anagram();
                    obj11.isanagram();
                    break;
                case 12:
                    PowerOfTwo obj12 = new PowerOfTwo();
                    obj12.ispower();
                    break;
                case 13:
                    DecimalToBinary obj13 = new DecimalToBinary();
                    obj13.isbinary();

                    break;
                case 14:
                    Dice obj14 = new Dice();
                    obj14.isdice();
                    break;
                case 15:

                    //call the mathod by main method
                    gambler obj15 = new gambler(); //creat a object for the class of gambler
                    obj15.isgambler();
                    break;
                case 16:
                    //angstrom obj16 = new angstrom();

                    armstrong.isangstrom();
                    break;
                case 17:
                    CouponGenerate obj17 = new CouponGenerate();
                    obj17.iscoupon(10);
                    break;
                case 18:
                    SumOfThreeNoZero obj18 = new SumOfThreeNoZero();
                    obj18.iszero();
                    break;
                case 19:
                    //SquareRoot obj19 = new SquareRoot();
                    SquareRoot.issquare();
                    break;
                case 20:
                    WindChill obj20 = new WindChill();
                    obj20.iswindchil();
                    break;
                case 21:
                    Distance obj21 = new Distance();
                    obj21.isdistance();
                    break;
                case 22:
                    Temperature obj22 = new Temperature();
                    obj22.istemperature();
                    break;

            }


        }
    }
}
