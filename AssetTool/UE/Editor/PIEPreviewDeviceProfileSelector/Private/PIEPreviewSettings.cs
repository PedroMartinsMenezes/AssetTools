namespace AssetTool
{
    [JsonAsset("PIEPreviewSettings")]
    public class UPIEPreviewSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}