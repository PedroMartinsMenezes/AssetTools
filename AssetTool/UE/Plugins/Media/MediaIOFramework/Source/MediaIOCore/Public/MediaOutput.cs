namespace AssetTool
{
    [JsonAsset("MediaOutput")]
    public class UMediaOutput : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}