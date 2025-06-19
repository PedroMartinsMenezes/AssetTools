namespace AssetTool
{
    [JsonAsset("StructViewerSettings")]
    public class UStructViewerSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}