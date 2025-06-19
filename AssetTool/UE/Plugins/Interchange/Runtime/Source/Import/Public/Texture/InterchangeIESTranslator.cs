namespace AssetTool
{
    [JsonAsset("InterchangeIESTranslator")]
    public class UInterchangeIESTranslator : UInterchangeTranslatorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}