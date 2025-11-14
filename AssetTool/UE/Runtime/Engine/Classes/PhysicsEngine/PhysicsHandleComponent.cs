namespace AssetTool
{
    [JsonAsset("PhysicsHandleComponent")]
    public class UPhysicsHandleComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}