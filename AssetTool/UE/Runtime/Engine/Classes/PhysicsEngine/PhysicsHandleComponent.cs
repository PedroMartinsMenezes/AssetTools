namespace AssetTool
{
    [JsonAsset("PhysicsHandleComponent")]
    public class UPhysicsHandleComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}