namespace AssetTool
{
    [JsonAsset("StructViewerSettings")]
    public class UStructViewerSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}