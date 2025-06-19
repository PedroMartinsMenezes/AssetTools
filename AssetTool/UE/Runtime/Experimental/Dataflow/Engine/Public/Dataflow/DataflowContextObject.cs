namespace AssetTool
{
    [JsonAsset("DataflowContextObject")]
    public class UDataflowContextObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}