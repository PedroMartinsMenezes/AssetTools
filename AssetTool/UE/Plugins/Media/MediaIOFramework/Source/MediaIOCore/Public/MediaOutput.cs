namespace AssetTool
{
    [JsonAsset("MediaOutput")]
    public class UMediaOutput : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}