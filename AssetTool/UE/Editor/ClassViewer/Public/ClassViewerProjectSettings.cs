namespace AssetTool
{
    [JsonAsset("ClassViewerProjectSettings")]
    public class UClassViewerProjectSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}