namespace AssetTool
{
    [JsonAsset("LyraBoundActionButton")]
    public class ULyraBoundActionButton : UCommonBoundActionButton
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}