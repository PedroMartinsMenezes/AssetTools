namespace AssetTool
{
    [JsonAsset("PCGPointNeighborhoodSettings")]
    public class UPCGPointNeighborhoodSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}