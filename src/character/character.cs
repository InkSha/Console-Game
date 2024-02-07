namespace Character
{

  /// <summary> 角色属性 </summary>
  public class CharacterAttributes
  {
    /// <summary> 攻击力 - 影响攻击造成的伤害 </summary>
    protected double attack = 8;
    /// <summary> 防御力 - 影响承受的攻击伤害 </summary>
    protected double defensive = 5;
    /// <summary> 生命力 - 归零死亡 </summary>
    protected double vitality = 100;
    /// <summary> 专注力 - 影响角色是否可施展技能 </summary>
    protected double concentration = 10;
    /// <summary> 记忆力 - 影响角色可施展的技能数量 </summary>
    protected double memory = 1;
    /// <summary> 行动力 - 影响角色可进行行动 </summary>
    protected double action = 10;
    /// <summary> 影响力 - 影响角色的交流 </summary>
    protected double impact = 1;
    /// <summary> 暴击率 - 影响角色攻击时是否暴击 </summary>
    protected double critical = 1;
    /// <summary> 命中率 - 影响角色攻击时是否被闪避 </summary>
    protected double hit = 5;
    /// <summary> 闪避率 - 影响受到攻击时的伤害 闪避伤害减免 90% </summary>
    protected double evade = 5;
    /// <summary> 角色等级 </summary>
    protected int level = 1;
    /// <summary> 属性点 </summary>
    protected int attributePoint = 0;

    /// <summary>
    /// 更改属性点
    /// </summary>
    /// <param name="point">更改的属性点数量 负数为减少</param>
    /// <returns>更改后的属性点</returns>
    protected int ChangeAttributePoint(int point)
    {
      attributePoint += point;
      return attributePoint;
    }

    /// <summary>
    /// 更改等级
    /// </summary>
    /// <param name="_level">需要更改的等级 负数为降级</param>
    /// <returns>更改后的等级</returns>
    protected int ChangeLevel(int _level)
    {
      level += _level;
      return level;
    }
  }

  /// <summary>
  /// 角色基类
  /// </summary>
  /// <param name="name">角色名称</param>
  /// <param name="sex">角色性别</param>
  /// <param name="age">角色年龄</param>
  public class CharacterBase(
    string name = "New Character!",
    bool sex = false,
    double age = 18
    ) : CharacterAction
  {
    /// <summary> 角色名称 </summary>
    protected string name = name;
    /// <summary> 角色年龄 </summary>
    protected double age = age;
    /// <summary> 角色性别 </summary>
    protected bool sex = sex;

    /// <summary>
    /// 读取角色信息
    /// </summary>
    /// <returns>角色信息</returns>
    public (string, double, bool, string) ReadInfo()
    {
      return (name, age, sex, $"{name}, ${age}岁, ${(sex ? '男' : '女')}性。");
    }
  }
}
