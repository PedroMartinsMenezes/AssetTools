namespace AssetTool
{
    [JsonAsset("DeformablePhysicsComponent")]
    public class UDeformablePhysicsComponent : UPrimitiveComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}