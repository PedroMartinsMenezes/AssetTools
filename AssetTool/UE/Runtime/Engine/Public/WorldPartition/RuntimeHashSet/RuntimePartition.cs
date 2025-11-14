namespace AssetTool
{
    [JsonAsset("RuntimePartition")]
    public class URuntimePartition : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}