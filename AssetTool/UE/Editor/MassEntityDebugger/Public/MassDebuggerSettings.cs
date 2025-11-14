namespace AssetTool
{
    [JsonAsset("MassDebuggerSettings")]
    public class UMassDebuggerSettings : UMassModuleSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}