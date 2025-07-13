namespace AssetTool
{
    [JsonAsset("DataRegistry")]
    public class UDataRegistry : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}