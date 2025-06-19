namespace AssetTool
{
    [JsonAsset("RetainerBox")]
    public class URetainerBox : UContentWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}