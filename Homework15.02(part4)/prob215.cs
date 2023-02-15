namespace Homework15._02_part4_
{
    internal class prob215
    {
        static void Main(string[] args)
        {
            //problem 215 ?
            //Console.WriteLine("Enter natural number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] array = new int[n];
            //for (int k = 0; k < array.Length; k++)
            //{
            //    array[k] = k + 1;
            //}
            //float sum = 0;
            //int i = 0;
            //for (i = 0; i < n; i += 2)
            //{
            //    array[i] = i;
            //    sum += array[i];
            //}
            //Console.WriteLine(sum);



            //problem 231
            //Console.WriteLine("Enter natural number :");
            //int n = int.Parse(Console.ReadLine()); //it doesnt work, i have to input manually//
            double[] array = new double[6] { 1, 2, 3, 4, 5, 6};
            double i = 0;
            double sum = 0;
            for (i = 0; i<array.Length; i++)
            {
               
                if (array[i]%2==0)
                {
                    array[i] = Math.Pow(array[i], 2);
                    sum += array[i];
                }
            }
            Console.WriteLine(sum);



            //problem 
        }
    }
}