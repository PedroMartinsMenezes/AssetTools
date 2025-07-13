namespace AssetTool
{
    [JsonAsset("ClassViewerProjectSettings")]
    public class UClassViewerProjectSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}