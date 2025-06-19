namespace AssetTool
{
    [JsonAsset("DeformablePhysicsComponent")]
    public class UDeformablePhysicsComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}