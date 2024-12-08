namespace AssetTool
{
    [JsonAsset("RuntimePartition")]
    public class URuntimePartition : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}