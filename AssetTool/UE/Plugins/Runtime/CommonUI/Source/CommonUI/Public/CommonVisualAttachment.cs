namespace AssetTool
{
    [JsonAsset("CommonVisualAttachment")]
    public class UCommonVisualAttachment : USizeBox
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}