namespace AssetTool
{
    [JsonAsset("OceanCollisionComponent")]
    public class UOceanCollisionComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OceanBoxCollisionComponent")]
    public class UOceanBoxCollisionComponent : UBoxComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}