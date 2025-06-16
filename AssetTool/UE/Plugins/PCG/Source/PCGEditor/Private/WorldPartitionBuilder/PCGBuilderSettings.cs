namespace AssetTool
{
    [JsonAsset("PCGBuilderSettings")]
    public class UPCGBuilderSettings : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}