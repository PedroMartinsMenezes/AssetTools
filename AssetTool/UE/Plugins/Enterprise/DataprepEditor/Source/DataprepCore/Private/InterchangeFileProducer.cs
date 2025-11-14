namespace AssetTool
{
    [JsonAsset("InterchangeFileProducer")]
    public class UInterchangeFileProducer : UDataprepContentProducer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}