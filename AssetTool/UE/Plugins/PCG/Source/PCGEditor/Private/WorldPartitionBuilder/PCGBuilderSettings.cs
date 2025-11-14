namespace AssetTool
{
    [JsonAsset("PCGBuilderSettings")]
    public class UPCGBuilderSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}