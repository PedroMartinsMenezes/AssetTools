namespace AssetTool
{
    [JsonAsset("CheckedStateBinding")]
    public class UCheckedStateBinding : UPropertyBinding
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}