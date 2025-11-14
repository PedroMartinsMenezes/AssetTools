namespace AssetTool
{
    [JsonAsset("MassSmartObjectSettings")]
    public class UMassSmartObjectSettings : UMassModuleSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}