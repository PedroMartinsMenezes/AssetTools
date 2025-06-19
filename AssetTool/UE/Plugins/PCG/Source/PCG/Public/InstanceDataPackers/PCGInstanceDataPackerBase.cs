namespace AssetTool
{
    [JsonAsset("PCGInstanceDataPackerBase")]
    public class UPCGInstanceDataPackerBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}