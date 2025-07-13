namespace AssetTool
{
    [JsonAsset("PhysicsObjectToolPropertySet")]
    public class UPhysicsObjectToolPropertySet : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CollisionGeometryVisualizationProperties")]
    public class UCollisionGeometryVisualizationProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}