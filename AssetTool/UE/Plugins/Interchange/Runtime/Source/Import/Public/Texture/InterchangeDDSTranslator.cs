namespace AssetTool
{
    [JsonAsset("InterchangeDDSTranslator")]
    public class UInterchangeDDSTranslator : UInterchangeTranslatorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}