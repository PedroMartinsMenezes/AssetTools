namespace AssetTool
{
    [JsonAsset("StructViewerProjectSettings")]
    public class UStructViewerProjectSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}