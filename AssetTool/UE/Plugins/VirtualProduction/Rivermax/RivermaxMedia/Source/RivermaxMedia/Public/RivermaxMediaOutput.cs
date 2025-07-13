namespace AssetTool
{
    [JsonAsset("RivermaxMediaOutput")]
    public class URivermaxMediaOutput : UMediaOutput
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}