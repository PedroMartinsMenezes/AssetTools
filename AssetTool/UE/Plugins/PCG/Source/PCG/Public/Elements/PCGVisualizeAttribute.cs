namespace AssetTool
{
    [JsonAsset("PCGVisualizeAttributeSettings")]
    public class UPCGVisualizeAttributeSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}