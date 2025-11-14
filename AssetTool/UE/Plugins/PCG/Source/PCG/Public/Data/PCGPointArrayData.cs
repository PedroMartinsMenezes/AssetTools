namespace AssetTool
{
    [JsonAsset("PCGPointArrayData")]
    public class UPCGPointArrayData : UPCGBasePointData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
