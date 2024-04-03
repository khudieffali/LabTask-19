internal class Program
{
     static void Main(string[] args)
    {
        head:
        Console.WriteLine("Minimum 4 reqemli eded daxil edin");
        string input=Console.ReadLine();
        bool check=int.TryParse(input, out int number);
        if (check == false) goto head;

       
        if(number>999) 
        {
            int endNum;
            int count=0;
            int temp=number;
            while (temp > 0)
            {
                temp /= 10;
                count++;
            }
            int[] arr = new int[count];
            for (int i = 0; i < arr.Length; i++)
            {
                endNum = number % 10;
                number /= 10;
                arr[i]= endNum;
                Console.WriteLine(arr[i]);
            }
        }
        else
        {
            goto head;
        }
        



    }
}