namespace AssetTool
{
    [JsonAsset("ColorBinding")]
    public class UColorBinding : UPropertyBinding
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}