using System;
using Character;

class Program
{
  static void Main()
  {
    CharacterBase hero = new("勇者");

    Console.WriteLine("使用AD键左右移动");

    int left = 44;
    int right = 44;
    bool toLeft = true;
    bool jump = false;

    Console.Clear();

    while (true)
    {
      string[] _h = {
        "".PadLeft(left+right+3,' '),
        "".PadLeft(left+right+3,' '),
        "".PadLeft(left+right+3,' '),
        "".PadLeft(left+right+3,' '),
        "".PadLeft(left+right+3,' '),
        "".PadLeft(left,' ')+(toLeft ? "  0` " : " `0 ")+"".PadRight(right, ' '),
        "".PadLeft(left,' ')+" /|\\"+"".PadRight(right, ' '),
        "".PadLeft(left,' ')+" /'\\ "+"".PadRight(right, ' '),
        "".PadLeft(left+right+3,'-')
      };

      Output.ResetLine(String.Join('\n', _h));

      jump = false;
      var (l, t) = Console.GetCursorPosition();
      var (key, _) = Output.ReadChar("");
      Console.SetCursorPosition(l, 0);

      if (key == 'a')
      {
        hero.MoveX(-1);
        if (left - 1 >= 0)
        {
          left--;
          right++;
          toLeft = true;
        }

      }
      else if (key == 'd')
      {
        hero.MoveX(1);
        if (right - 1 >= 0)
        {
          right--;
          left++;
          toLeft = false;
        }
      }
      else if (key == 'j')
      {
        if (!jump)
        {
          hero.MoveY(2);
          jump = true;
        }
      }
    }
  }
}
