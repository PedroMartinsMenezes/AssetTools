namespace AssetTool
{
    [JsonAsset("InterchangeFileProducer")]
    public class UInterchangeFileProducer : UDataprepContentProducer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}