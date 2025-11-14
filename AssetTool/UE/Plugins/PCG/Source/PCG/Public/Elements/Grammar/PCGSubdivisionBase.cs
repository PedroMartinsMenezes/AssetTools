namespace AssetTool
{
    [JsonAsset("PCGSubdivisionBaseSettings")]
    public class UPCGSubdivisionBaseSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}