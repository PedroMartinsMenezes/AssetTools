namespace AssetTool
{
    [JsonAsset("PCGDataBinding")]
    public class UPCGDataBinding : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}