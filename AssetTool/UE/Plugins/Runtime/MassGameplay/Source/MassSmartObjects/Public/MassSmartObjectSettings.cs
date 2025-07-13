namespace AssetTool
{
    [JsonAsset("MassSmartObjectSettings")]
    public class UMassSmartObjectSettings : UMassModuleSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}