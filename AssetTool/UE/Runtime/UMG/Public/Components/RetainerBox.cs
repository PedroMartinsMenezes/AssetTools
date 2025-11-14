namespace AssetTool
{
    [JsonAsset("RetainerBox")]
    public class URetainerBox : UContentWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}