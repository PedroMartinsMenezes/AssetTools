namespace AssetTool
{
    [JsonAsset("ContextObjectStore")]
    public class UContextObjectStore : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}