using System;

namespace Replace.Number
{
  public class NumberList
  {
    public int CreateNumberList { get; set; }

    public NumberList(int _userNumber)
    {
      //List<string> numberList = new List<string> {};
      for (int i = 0; i<= _userNumber; i += 1) 
      {
        if (i%3 == 0 && i%5 == 0)
        {
          Console.WriteLine("ping-pong!");
        }
        else if (i%3 == 0)
        {
          Console.WriteLine("ping!");
        }
        else if (i%5 == 0)
        {
          Console.WriteLine("pong!");
        }
        else
        {
          Console.WriteLine(i);
        }
      }
    }
  }
}