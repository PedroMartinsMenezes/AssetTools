namespace AssetTool
{
    [JsonAsset("RivermaxMediaCapture")]
    public class URivermaxMediaCapture : UMediaCapture
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}