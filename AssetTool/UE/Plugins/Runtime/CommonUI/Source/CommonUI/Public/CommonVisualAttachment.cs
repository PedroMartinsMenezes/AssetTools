namespace AssetTool
{
    [JsonAsset("CommonVisualAttachment")]
    public class UCommonVisualAttachment : USizeBox
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}