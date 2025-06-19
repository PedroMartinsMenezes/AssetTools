namespace AssetTool
{
    [JsonAsset("BoolBinding")]
    public class UBoolBinding : UPropertyBinding
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}