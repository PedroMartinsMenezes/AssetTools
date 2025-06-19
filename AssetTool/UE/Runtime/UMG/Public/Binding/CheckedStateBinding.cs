namespace AssetTool
{
    [JsonAsset("CheckedStateBinding")]
    public class UCheckedStateBinding : UPropertyBinding
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}