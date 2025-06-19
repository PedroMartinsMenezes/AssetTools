namespace AssetTool
{
    [JsonAsset("PCGOuterIntersectionSettings")]
    public class UPCGOuterIntersectionSettings : UPCGSettingsWithDynamicInputs
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}