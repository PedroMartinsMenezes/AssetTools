namespace AssetTool
{
    [JsonAsset("StructViewerProjectSettings")]
    public class UStructViewerProjectSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}