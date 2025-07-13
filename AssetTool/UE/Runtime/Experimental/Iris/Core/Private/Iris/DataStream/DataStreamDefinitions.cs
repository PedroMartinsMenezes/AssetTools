namespace AssetTool
{
    [JsonAsset("DataStreamDefinitions")]
    public class UDataStreamDefinitions : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}