namespace AssetTool
{
    [JsonAsset("PhysicsControlComponent")]
    public class UPhysicsControlComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}