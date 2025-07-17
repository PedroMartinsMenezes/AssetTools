namespace AssetTool
{
    [JsonAsset("LyraBoundActionButton")]
    public class ULyraBoundActionButton : UCommonBoundActionButton
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}