namespace AssetTool
{
    [JsonAsset("PCGPointNeighborhoodSettings")]
    public class UPCGPointNeighborhoodSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}