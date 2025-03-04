namespace AssetTool
{
    [JsonAsset("FileMediaOutput")]
    public class UFileMediaOutput : UMediaOutput
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}