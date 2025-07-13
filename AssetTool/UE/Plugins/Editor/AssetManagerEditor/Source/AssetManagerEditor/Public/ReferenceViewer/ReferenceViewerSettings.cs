namespace AssetTool
{
    [JsonAsset("ReferenceViewerSettings")]
    public class UReferenceViewerSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}