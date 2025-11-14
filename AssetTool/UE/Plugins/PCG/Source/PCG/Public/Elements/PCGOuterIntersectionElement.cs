namespace AssetTool
{
    [JsonAsset("PCGOuterIntersectionSettings")]
    public class UPCGOuterIntersectionSettings : UPCGSettingsWithDynamicInputs
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}