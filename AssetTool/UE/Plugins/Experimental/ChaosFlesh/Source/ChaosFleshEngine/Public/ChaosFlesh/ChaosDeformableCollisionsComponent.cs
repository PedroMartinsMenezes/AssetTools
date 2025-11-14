namespace AssetTool
{
    [JsonAsset("DeformableCollisionsComponent")]
    public class UDeformableCollisionsComponent : UDeformablePhysicsComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}