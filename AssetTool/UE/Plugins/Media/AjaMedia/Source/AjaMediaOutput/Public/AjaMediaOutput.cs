namespace AssetTool
{
    [JsonAsset("AjaMediaOutput")]
    public class UAjaMediaOutput : UMediaOutput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}