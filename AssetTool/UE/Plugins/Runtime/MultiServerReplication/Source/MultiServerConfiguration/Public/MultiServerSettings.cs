namespace AssetTool
{
    [JsonAsset("MultiServerSettings")]
    public class UMultiServerSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}