namespace AssetTool
{
    [JsonAsset("AsyncPhysicsInputComponent")]
    public class UAsyncPhysicsInputComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}