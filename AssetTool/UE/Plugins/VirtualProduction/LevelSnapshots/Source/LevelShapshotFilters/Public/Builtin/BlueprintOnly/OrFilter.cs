namespace AssetTool
{
    [JsonAsset("OrFilter")]
    public class UOrFilter : UParentFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}