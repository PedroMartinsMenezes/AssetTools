namespace AssetTool
{
    [JsonAsset("VisibilityBinding")]
    public class UVisibilityBinding : UPropertyBinding
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}