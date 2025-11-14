namespace AssetTool
{
    [JsonAsset("CommonTextStyle")]
    public class UCommonTextStyle : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonTextScrollStyle")]
    public class UCommonTextScrollStyle : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonTextBlock")]
    public class UCommonTextBlock : UTextBlock
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}