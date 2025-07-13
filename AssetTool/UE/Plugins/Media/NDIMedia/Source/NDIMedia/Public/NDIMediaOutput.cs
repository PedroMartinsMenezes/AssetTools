namespace AssetTool
{
    [JsonAsset("NDIMediaOutput")]
    public class UNDIMediaOutput : UMediaOutput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}