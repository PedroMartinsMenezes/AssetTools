namespace AssetTool
{
    [JsonAsset("AndFilter")]
    public class UAndFilter : UParentFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}