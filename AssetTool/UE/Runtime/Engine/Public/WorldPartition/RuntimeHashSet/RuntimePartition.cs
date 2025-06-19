namespace AssetTool
{
    [JsonAsset("RuntimePartition")]
    public class URuntimePartition : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}