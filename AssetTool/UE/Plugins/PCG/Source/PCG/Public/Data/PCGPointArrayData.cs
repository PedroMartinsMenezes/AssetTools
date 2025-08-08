namespace AssetTool
{
    [JsonAsset("PCGPointArrayData")]
    public class UPCGPointArrayData : UPCGBasePointData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
