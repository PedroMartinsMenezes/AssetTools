namespace AssetTool
{
    [JsonAsset("InterchangePSDTranslator")]
    public class UInterchangePSDTranslator : UInterchangeTranslatorBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}