namespace AssetTool
{
    [JsonAsset("PCGSubdivisionBaseSettings")]
    public class UPCGSubdivisionBaseSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}