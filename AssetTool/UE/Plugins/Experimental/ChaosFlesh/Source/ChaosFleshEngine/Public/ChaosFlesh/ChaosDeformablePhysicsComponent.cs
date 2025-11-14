namespace AssetTool
{
    [JsonAsset("DeformablePhysicsComponent")]
    public class UDeformablePhysicsComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}