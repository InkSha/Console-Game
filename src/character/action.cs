namespace Character
{
  /// <summary>
  /// 角色行动
  /// </summary>
  /// <param name="speed">行动速度</param>
  public class CharacterAction(double speed = 5) : CharacterAttributes
  {
    /// <summary> 角色 (x,y,z) 位置 </summary>
    protected (double, double, double) position = (0, 0, 0);
    /// <summary> 移动速度 </summary>
    protected double speed = speed;


    public (double, double, double) MoveX(double x = 0)
    {
      position.Item1 += x;
      return position;
    }

    public (double, double, double) MoveY(double y = 0)
    {
      position.Item2 += y;
      return position;
    }

    public (double, double, double) MoveZ(double z = 0)
    {
      position.Item3 += z;
      return position;
    }

    public (double, double, double) Move(double x = 0, double y = 0, double z = 0)
    {
      MoveX(x);
      MoveY(y);
      MoveZ(z);
      return position;
    }
  }
}
