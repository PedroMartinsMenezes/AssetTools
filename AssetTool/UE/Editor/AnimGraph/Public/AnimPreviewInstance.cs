namespace AssetTool
{
    [JsonAsset("AnimPreviewInstance")]
    public class UAnimPreviewInstance : UAnimSingleNodeInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}