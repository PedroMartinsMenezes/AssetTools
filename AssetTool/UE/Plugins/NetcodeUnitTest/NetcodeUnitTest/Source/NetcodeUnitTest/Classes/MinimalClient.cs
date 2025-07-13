namespace AssetTool
{
    [JsonAsset("MinimalClient")]
    public class UMinimalClient : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}