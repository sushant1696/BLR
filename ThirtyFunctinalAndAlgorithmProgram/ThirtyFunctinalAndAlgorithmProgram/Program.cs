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
            Console.WriteLine("23 for monthly payment");
            Console.WriteLine("24 for vending machine");
            Console.WriteLine("25 for stopwatch");
            Console.WriteLine("26 for nible swap");
            Console.WriteLine(" 27 for factorial of a number");
            Console.WriteLine(" 28 for day of week");
            Console.WriteLine(" 29 for insertion sort");
            Console.WriteLine(" 30 Non negative square no");
            Console.WriteLine(" 31 for PrimePal no");

            int a = int.Parse(Console.ReadLine());


            switch (a)
            {
                case 1:
                    Even obj = new Even();
                    obj.IsEven();
                    break;
                case 2:
                    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                    int hi = arr.Length;
                    int x = Convert.ToInt32(Console.ReadLine());
                    BinerySearch obj1=new BinerySearch();
                    int result = obj1.isBinary(arr,0,hi-1,x);
                    Console.WriteLine("element is present at index", result);
                    break;
                case 3:
                    PrimePalindrom obj2 = new PrimePalindrom();
                    obj2.Isprime();
                    break;

                case 4:
                    int n = 123;
                    ReverseANumber obj3 = new ReverseANumber();
                    obj3.IsReverse(n);
                    break;
                case 5:
                    RandomNo obj5 = new RandomNo();
                    double sum=obj5.IsRandom(1,10);
                    Console.WriteLine("the generated random no is:"+sum);

                    break;
                case 6:
                    // TwoDArray obj6 = new TwoDArray();
                    TwoDArray.IsArray();
                    break;
                case 7:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.IsCoin(100);
                    break;
                case 8:
                    LeapYear obj8 = new LeapYear();
                    obj8.Isleap();
                    break;
                case 9:
                    EqualsString obj9 = new EqualsString();
                    obj9.IsEqual();
                    break;
                case 10:
                    // BubbleSort obj10 = new BubbleSort();
                    int[] array = { 9,8,6,4,87 };
                     n = array.Length;                
                BubbleSort.isBubble(array,n);
                    break;
                case 11:
                   
                    Anagram obj11 = new Anagram();
                    obj11.IsAnagram();
                    break;
                case 12:
                    PowerOfTwo obj12 = new PowerOfTwo();
                    obj12.Ispower();
                    break;
                case 13:
                    DecimalToBinary obj13 = new DecimalToBinary();
                    obj13.IsBinary();

                    break;
                case 14:
                    Dice obj14 = new Dice();
                    obj14.IsDice(10);
                    break;
                case 15:

                    //call the mathod by main method
                    Gambler obj15 = new Gambler(); //creat a object for the class of gambler
                    obj15.IsGambler();
                    break;
                case 16:
                    //angstrom obj16 = new angstrom();

                    armstrong.IsArmstrong();
                    break;
                case 17:
                    CouponGenerate obj17 = new CouponGenerate();
                    obj17.IsCoupon(10);
                    break;
                case 18:
                    SumOfThreeNoZero obj18 = new SumOfThreeNoZero();
                    obj18.IsZero();
                    break;
                case 19:
                    //SquareRoot obj19 = new SquareRoot();
                    SquareRoot.IsSquare();
                    break;
                case 20:
                    WindChill obj20 = new WindChill();
                    obj20.IsWindchil();
                    break;
                case 21:
                    Distance obj21 = new Distance();
                    obj21.IsDistance();
                    break;
                case 22:
                    Temperature obj22 = new Temperature();
                    obj22.IsTemperature();
                    break;
                case 23:
                    MonthlyPayment obj23 = new MonthlyPayment();
                    obj23.Ispayment(5000,3,5);
                    break;
                case 24:
                    VendingMachine obj24 = new VendingMachine();
                    obj24.IsMachine(1035);
                    break;
                case 25:
                    StopWatch stopwatch = new StopWatch();
                    stopwatch.Main();
                    break;
                case 26:
                    SwapNibble swap = new SwapNibble();
                   
                     Console.WriteLine(swap.IsSwap(100));
                    break;
                case 27:
                    Factor fac = new Factor();
                    fac.IsFactor(5);
                    break;
                case 28:
                    CalenderDayOfWeek day = new CalenderDayOfWeek();
                    day.isDay(30, 12, 2019);
                    break;
                case 29:
                    InsertionSort.Insertion();
                    break;
                case 30:
                    
                    SquareRootOfNonNegativeNo.IsSquar();
                    break;
                case 31:
                    PrimePal pal = new PrimePal();
                    pal.IsPrimePal();
                    break;
            }


        }
    }
}
