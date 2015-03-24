
using System;

namespace InternetTime
{
  /// <summary>
  /// Main entry point for the utility
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