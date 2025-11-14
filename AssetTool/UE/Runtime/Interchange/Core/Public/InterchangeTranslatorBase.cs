namespace AssetTool
{
    [JsonAsset("InterchangeTranslatorSettings")]
    public class UInterchangeTranslatorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeTranslatorBase")]
    public class UInterchangeTranslatorBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}