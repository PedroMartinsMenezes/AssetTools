namespace AssetTool
{
    [JsonAsset("InterchangeTranslatorSettings")]
    public class UInterchangeTranslatorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeTranslatorBase")]
    public class UInterchangeTranslatorBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}