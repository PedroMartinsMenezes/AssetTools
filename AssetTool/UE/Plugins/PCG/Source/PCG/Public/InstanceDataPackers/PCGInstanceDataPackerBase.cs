namespace AssetTool
{
    [JsonAsset("PCGInstanceDataPackerBase")]
    public class UPCGInstanceDataPackerBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}