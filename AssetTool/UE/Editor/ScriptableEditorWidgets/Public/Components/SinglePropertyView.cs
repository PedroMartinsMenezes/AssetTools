namespace AssetTool
{
    [JsonAsset("SinglePropertyView")]
    public class USinglePropertyView : UPropertyViewBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}