namespace AssetTool
{
    [JsonAsset("InterchangeFbxTranslatorSettings")]
    public class UInterchangeFbxTranslatorSettings : UInterchangeTranslatorSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeFbxTranslator")]
    public class UInterchangeFbxTranslator : UInterchangeTranslatorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}