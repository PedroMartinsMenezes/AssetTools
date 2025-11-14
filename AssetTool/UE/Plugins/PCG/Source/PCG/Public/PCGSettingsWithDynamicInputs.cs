namespace AssetTool
{
    [JsonAsset("PCGSettingsWithDynamicInputs")]
    public class UPCGSettingsWithDynamicInputs : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}