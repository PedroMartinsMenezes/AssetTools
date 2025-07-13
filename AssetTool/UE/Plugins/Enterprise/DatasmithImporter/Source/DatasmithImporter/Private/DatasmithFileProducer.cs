namespace AssetTool
{
    [JsonAsset("DatasmithFileProducer")]
    public class UDatasmithFileProducer : UDataprepContentProducer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DatasmithDirProducer")]
    public class UDatasmithDirProducer : UDataprepContentProducer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}