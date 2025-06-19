namespace AssetTool
{
    [JsonAsset("PCGNode")]
    public class UPCGNode : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}