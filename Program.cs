using System;

class Program
{
  static void Main()
  {

    for (int i = 0; i < 10; i++)
    {
      Output.ResetLine($"当前执行 {i} 次!");
      Thread.Sleep(1000);
    }

    var (_char, _damage) = Output.ReadChar("请按任意键进行输出");
    Console.WriteLine("输入 {0} 键", _char);
    Attk(_damage);
  }

  private static void Attk(int damage)
  {
    Console.WriteLine("造成 {0} 伤害", damage);
  }
}
