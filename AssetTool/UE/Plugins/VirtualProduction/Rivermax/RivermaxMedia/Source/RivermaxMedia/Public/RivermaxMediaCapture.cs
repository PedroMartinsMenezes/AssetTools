namespace AssetTool
{
    [JsonAsset("RivermaxMediaCapture")]
    public class URivermaxMediaCapture : UMediaCapture
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}