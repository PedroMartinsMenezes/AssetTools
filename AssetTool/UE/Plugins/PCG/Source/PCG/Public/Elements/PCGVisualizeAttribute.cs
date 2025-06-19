namespace AssetTool
{
    [JsonAsset("PCGVisualizeAttributeSettings")]
    public class UPCGVisualizeAttributeSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}