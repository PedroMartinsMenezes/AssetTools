namespace AssetTool
{
    [JsonAsset("AjaMediaOutput")]
    public class UAjaMediaOutput : UMediaOutput
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}