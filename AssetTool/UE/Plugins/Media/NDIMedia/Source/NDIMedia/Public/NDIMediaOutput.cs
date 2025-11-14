namespace AssetTool
{
    [JsonAsset("NDIMediaOutput")]
    public class UNDIMediaOutput : UMediaOutput
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}