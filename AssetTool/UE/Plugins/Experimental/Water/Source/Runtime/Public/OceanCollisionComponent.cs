namespace AssetTool
{
    [JsonAsset("OceanCollisionComponent")]
    public class UOceanCollisionComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OceanBoxCollisionComponent")]
    public class UOceanBoxCollisionComponent : UBoxComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}