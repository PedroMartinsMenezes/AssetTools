namespace AssetTool
{
    [JsonAsset("PCGSettingsWithDynamicInputs")]
    public class UPCGSettingsWithDynamicInputs : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}