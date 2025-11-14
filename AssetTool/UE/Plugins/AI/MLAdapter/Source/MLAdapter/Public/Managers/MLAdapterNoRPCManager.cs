namespace AssetTool
{
    [JsonAsset("MLAdapterNoRPCManager")]
    public class UMLAdapterNoRPCManager : UMLAdapterManager
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}