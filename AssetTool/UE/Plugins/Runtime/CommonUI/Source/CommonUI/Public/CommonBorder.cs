namespace AssetTool
{
    [JsonAsset("CommonBorderStyle")]
    public class UCommonBorderStyle : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonBorder")]
    public class UCommonBorder : UBorder
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}