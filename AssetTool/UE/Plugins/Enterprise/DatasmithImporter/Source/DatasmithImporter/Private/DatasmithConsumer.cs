namespace AssetTool
{
    [JsonAsset("DatasmithConsumer")]
    public class UDatasmithConsumer : UDataprepContentConsumer
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}