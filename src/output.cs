using System;

public class Output
{

  /// <summary>
  /// 获取一行输入内容
  /// </summary>
  /// <param name="message">输入内容提示</param>
  /// <returns>获取的输入内容</returns>
  public static string ReadLine(string message = "Please input.")
  {
    Console.WriteLine("");
    Console.WriteLine(message);
    string? result = Console.ReadLine();
    result ??= "";
    return result;
  }

  /// <summary>
  /// 获取单个输入字符
  /// </summary>
  /// <param name="message">输入内容提示</param>
  /// <returns>获取的输入字符</returns>
  public static (char, int) ReadChar(string message = "Please input.")
  {
    Console.WriteLine("");
    Console.WriteLine(message);
    var result = Console.ReadKey().KeyChar;
    ResetLine();
    return (result, result - 48);
  }

  /// <summary>
  /// 重写当前行
  /// </summary>
  /// <param name="message">重写内容</param>
  public static void ResetLine(string message = "")
  {
    int currentLineCursor = Console.CursorTop; //记录当前光标位置
    Console.SetCursorPosition(0, Console.CursorTop); //将光标至于当前行的开始位置
    Console.Write(new string(' ', Console.WindowWidth)); //用空格将当前行填满，相当于清除当前行
    Console.SetCursorPosition(0, currentLineCursor); //将光标恢复至开始时的位置
    Console.Write(message);
  }
}
