namespace AssetTool
{
    [JsonAsset("CommonTextStyle")]
    public class UCommonTextStyle : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonTextScrollStyle")]
    public class UCommonTextScrollStyle : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonTextBlock")]
    public class UCommonTextBlock : UTextBlock
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}