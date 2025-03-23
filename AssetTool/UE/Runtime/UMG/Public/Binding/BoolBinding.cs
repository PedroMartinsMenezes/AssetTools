namespace AssetTool
{
    [JsonAsset("BoolBinding")]
    public class UBoolBinding : UPropertyBinding
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}