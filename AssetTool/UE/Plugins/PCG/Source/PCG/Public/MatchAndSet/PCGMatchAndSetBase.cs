namespace AssetTool
{
    [JsonAsset("PCGMatchAndSetBase")]
    public class UPCGMatchAndSetBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}