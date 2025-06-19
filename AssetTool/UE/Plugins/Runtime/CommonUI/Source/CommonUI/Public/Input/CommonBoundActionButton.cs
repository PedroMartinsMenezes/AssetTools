namespace AssetTool
{
    [JsonAsset("CommonBoundActionButton")]
    public class UCommonBoundActionButton : UCommonButtonBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}