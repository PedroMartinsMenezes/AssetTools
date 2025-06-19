namespace AssetTool
{
    [JsonAsset("PCGSettingsWithDynamicInputs")]
    public class UPCGSettingsWithDynamicInputs : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}