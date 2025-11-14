namespace AssetTool
{
    [JsonAsset("InterchangeFbxTranslatorSettings")]
    public class UInterchangeFbxTranslatorSettings : UInterchangeTranslatorSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeFbxTranslator")]
    public class UInterchangeFbxTranslator : UInterchangeTranslatorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}