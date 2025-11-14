namespace AssetTool
{
    [JsonAsset("PhysicsSpringComponent")]
    public class UPhysicsSpringComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}