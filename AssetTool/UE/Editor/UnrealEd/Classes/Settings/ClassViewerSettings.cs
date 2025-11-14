namespace AssetTool
{
    [JsonAsset("ClassViewerSettings")]
    public class UClassViewerSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}