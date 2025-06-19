namespace AssetTool
{
    [JsonAsset("PCGBuilderSettings")]
    public class UPCGBuilderSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}