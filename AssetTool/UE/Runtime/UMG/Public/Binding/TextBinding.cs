namespace AssetTool
{
    [JsonAsset("TextBinding")]
    public class UTextBinding : UPropertyBinding
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}