namespace AssetTool
{
    [JsonAsset("AndFilter")]
    public class UAndFilter : UParentFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}