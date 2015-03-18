using System;

namespace InternetTime
{
  /// <summary>
  /// Summary description for Class1
  /// </summary>
  public class Program
  {
    [STAThread]
    public static void Main(string[] args)
    {
      SNTPClient client = new SNTPClient("time.nist.gov");
      client.Connect(false);
      Console.WriteLine(client.InternetTime);
    }
  }
}