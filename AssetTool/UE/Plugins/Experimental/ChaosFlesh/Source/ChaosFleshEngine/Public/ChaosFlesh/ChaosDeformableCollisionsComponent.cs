namespace AssetTool
{
    [JsonAsset("DeformableCollisionsComponent")]
    public class UDeformableCollisionsComponent : UDeformablePhysicsComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}