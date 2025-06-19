namespace AssetTool
{
    [JsonAsset("CommonVisibilitySwitcherSlot")]
    public class UCommonVisibilitySwitcherSlot : UOverlaySlot
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}