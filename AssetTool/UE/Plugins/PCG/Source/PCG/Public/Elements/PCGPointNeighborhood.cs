namespace AssetTool
{
    [JsonAsset("PCGPointNeighborhoodSettings")]
    public class UPCGPointNeighborhoodSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}