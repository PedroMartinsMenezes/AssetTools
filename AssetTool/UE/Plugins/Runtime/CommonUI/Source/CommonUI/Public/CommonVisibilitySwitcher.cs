namespace AssetTool
{
    [JsonAsset("CommonVisibilitySwitcher")]
    public class UCommonVisibilitySwitcher : UOverlay
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}