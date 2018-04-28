using System;
using System.IO;

using NUnit.Framework;

using Hoi;


namespace Hoi.UnitTests
{
  internal class ConsoleReader : IDisposable
  {
    private StringWriter _output = new StringWriter();
    private TextWriter _originalOutput;

    public ConsoleReader()
    {
      this._originalOutput = Console.Out;
      Console.SetOut(_output);
    }

    public void Dispose()
    {
      Console.SetOut(_originalOutput);
      Console.Write(this.ToString());
      this._output.Dispose();
    }

    public override string ToString()
    {
      return this._output.ToString();
    }
  }

  [TestFixture]
  public class ProgramTest
  {
    [Test]
    public void Test_GetWord()
    {
      Assert.IsTrue("Hoi Zäme!" == Program.GetWord(),
        "It's not \"Hoi Zäme!\"");
    }

    [Test]
    public void Test_Main()
    {
      using (ConsoleReader reader = new ConsoleReader())
      {
        string[] args = {};
        Hoi.Program.Main(args);

        Assert.IsTrue("Hoi Zäme!\n" == reader.ToString(),
          "It's not written in console");
      }
    }
  }
}
