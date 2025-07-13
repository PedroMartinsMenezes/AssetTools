namespace AssetTool
{
    [JsonAsset("MRMeshBodyHolder")]
    public class UMRMeshBodyHolder : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MRMeshComponent")]
    public class UMRMeshComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}