namespace AssetTool
{
    [JsonAsset("FloatBinding")]
    public class UFloatBinding : UPropertyBinding
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}