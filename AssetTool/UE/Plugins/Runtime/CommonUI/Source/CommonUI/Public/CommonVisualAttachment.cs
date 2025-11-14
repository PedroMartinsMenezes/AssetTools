namespace AssetTool
{
    [JsonAsset("CommonVisualAttachment")]
    public class UCommonVisualAttachment : USizeBox
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}