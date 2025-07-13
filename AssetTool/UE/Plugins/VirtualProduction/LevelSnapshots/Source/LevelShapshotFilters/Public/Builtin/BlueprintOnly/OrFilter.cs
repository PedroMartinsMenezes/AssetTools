namespace AssetTool
{
    [JsonAsset("OrFilter")]
    public class UOrFilter : UParentFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}