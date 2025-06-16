namespace AssetTool
{
    [JsonAsset("PCGSubdivisionBaseSettings")]
    public class UPCGSubdivisionBaseSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}