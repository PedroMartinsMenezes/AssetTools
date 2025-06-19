namespace AssetTool
{
    [JsonAsset("FloatBinding")]
    public class UFloatBinding : UPropertyBinding
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}