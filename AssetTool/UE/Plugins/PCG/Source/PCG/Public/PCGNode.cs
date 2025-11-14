namespace AssetTool
{
    [JsonAsset("PCGNode")]
    public class UPCGNode : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}