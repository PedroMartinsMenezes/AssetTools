namespace AssetTool
{
    [JsonAsset("MassDebuggerSettings")]
    public class UMassDebuggerSettings : UMassModuleSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}