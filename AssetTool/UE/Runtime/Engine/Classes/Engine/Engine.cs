namespace AssetTool
{
    [JsonAsset("Engine")]
    public class UEngine : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}