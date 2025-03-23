namespace AssetTool
{
    [JsonAsset("VisibilityBinding")]
    public class UVisibilityBinding : UPropertyBinding
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}