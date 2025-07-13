namespace AssetTool
{
    [JsonAsset("DatasmithConsumer")]
    public class UDatasmithConsumer : UDataprepContentConsumer
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}