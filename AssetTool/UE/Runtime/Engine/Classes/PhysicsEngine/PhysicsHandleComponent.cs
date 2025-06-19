namespace AssetTool
{
    [JsonAsset("PhysicsHandleComponent")]
    public class UPhysicsHandleComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}