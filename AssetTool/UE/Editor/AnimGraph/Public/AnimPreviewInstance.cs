namespace AssetTool
{
    [JsonAsset("AnimPreviewInstance")]
    public class UAnimPreviewInstance : UAnimSingleNodeInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}