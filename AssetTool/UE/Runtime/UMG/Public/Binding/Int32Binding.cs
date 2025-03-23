namespace AssetTool
{
    [JsonAsset("Int32Binding")]
    public class UInt32Binding : UPropertyBinding
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}