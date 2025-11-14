namespace AssetTool
{
    [JsonAsset("PCGCollisionWrapperData")]
    public class UPCGCollisionWrapperData : UPCGSpatialData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}