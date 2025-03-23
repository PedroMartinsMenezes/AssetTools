namespace AssetTool
{
    [JsonAsset("CheckedStateBinding")]
    public class UCheckedStateBinding : UPropertyBinding
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}