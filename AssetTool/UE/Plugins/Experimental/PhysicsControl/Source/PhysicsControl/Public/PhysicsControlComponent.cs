namespace AssetTool
{
    [JsonAsset("PhysicsControlComponent")]
    public class UPhysicsControlComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}