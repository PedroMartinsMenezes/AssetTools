namespace AssetTool
{
    [JsonAsset("PCGCreatePointsSettings")]
    public class UPCGCreatePointsSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}