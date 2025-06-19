namespace AssetTool
{
    [JsonAsset("FileMediaOutput")]
    public class UFileMediaOutput : UMediaOutput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}