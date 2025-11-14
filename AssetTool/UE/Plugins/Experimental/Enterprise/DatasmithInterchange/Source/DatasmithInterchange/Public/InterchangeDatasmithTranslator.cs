namespace AssetTool
{
    [JsonAsset("InterchangeDatasmithTranslatorSettings")]
    public class UInterchangeDatasmithTranslatorSettings : UInterchangeTranslatorSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeDatasmithTranslator")]
    public class UInterchangeDatasmithTranslator : UInterchangeTranslatorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}