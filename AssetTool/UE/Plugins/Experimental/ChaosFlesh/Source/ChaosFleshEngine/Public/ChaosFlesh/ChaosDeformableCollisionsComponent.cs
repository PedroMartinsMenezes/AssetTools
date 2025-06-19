namespace AssetTool
{
    [JsonAsset("DeformableCollisionsComponent")]
    public class UDeformableCollisionsComponent : UDeformablePhysicsComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}