namespace AssetTool
{
    [JsonAsset("InterchangeDnaTranslator")]
    public class UInterchangeDnaTranslator : UInterchangeTranslatorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}