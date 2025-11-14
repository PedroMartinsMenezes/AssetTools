namespace AssetTool
{
    [JsonAsset("SinglePropertyView")]
    public class USinglePropertyView : UPropertyViewBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}