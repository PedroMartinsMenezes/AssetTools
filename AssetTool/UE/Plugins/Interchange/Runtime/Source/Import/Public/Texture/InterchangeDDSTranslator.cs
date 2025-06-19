namespace AssetTool
{
    [JsonAsset("InterchangeDDSTranslator")]
    public class UInterchangeDDSTranslator : UInterchangeTranslatorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}