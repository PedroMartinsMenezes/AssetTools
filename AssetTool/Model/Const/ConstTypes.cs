namespace AssetTool
{
    #region Bool
    public interface ConstBool { bool Value { get; } }
    public class ConstTrue : ConstBool { public bool Value => true; }
    public class ConstFalse : ConstBool { public bool Value => false; }
    #endregion

    #region Int
    public interface ConstInt { int Value { get; } }
    public class Const1 : ConstInt { public int Value => 1; }
    public class Const2 : ConstInt { public int Value => 2; }
    public class Const3 : ConstInt { public int Value => 3; }
    public class Const4 : ConstInt { public int Value => 4; }
    #endregion
}
