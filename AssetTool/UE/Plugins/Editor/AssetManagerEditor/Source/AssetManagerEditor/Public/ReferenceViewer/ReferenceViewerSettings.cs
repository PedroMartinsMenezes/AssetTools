namespace AssetTool
{
    [JsonAsset("ReferenceViewerSettings")]
    public class UReferenceViewerSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}