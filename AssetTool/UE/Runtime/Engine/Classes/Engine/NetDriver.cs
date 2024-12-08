namespace AssetTool
{
    [JsonAsset("NetDriver")]
    public class UNetDriver : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}