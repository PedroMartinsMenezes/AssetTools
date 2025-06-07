namespace AssetTool
{
    [JsonAsset("InterchangeFbxTranslatorSettings")]
    public class UInterchangeFbxTranslatorSettings : UInterchangeTranslatorSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeFbxTranslator")]
    public class UInterchangeFbxTranslator : UInterchangeTranslatorBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}