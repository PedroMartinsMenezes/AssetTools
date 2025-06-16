namespace AssetTool
{
    [JsonAsset("PCGOuterIntersectionSettings")]
    public class UPCGOuterIntersectionSettings : UPCGSettingsWithDynamicInputs
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}