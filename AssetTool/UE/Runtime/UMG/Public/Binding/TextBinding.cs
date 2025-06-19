namespace AssetTool
{
    [JsonAsset("TextBinding")]
    public class UTextBinding : UPropertyBinding
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}