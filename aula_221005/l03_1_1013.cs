using System;
public class Program {
  public static void Main () {
    string[] nums = Console.ReadLine().Split();
    int a = int.Parse(nums[0]);
    int b = int.Parse(nums[1]);
    int c = int.Parse(nums[2]);
    int maior = (a + b + Math.Abs(a - b)) / 2;
    maior = (c + maior + Math.Abs(c - maior)) / 2;
    Console.WriteLine($"{maior} eh o maior");
  }
}