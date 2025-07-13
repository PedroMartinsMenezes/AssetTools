namespace AssetTool
{
    [JsonAsset("MLAdapterNoRPCManager")]
    public class UMLAdapterNoRPCManager : UMLAdapterManager
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}