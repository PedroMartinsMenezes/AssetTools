namespace AssetTool
{
    [JsonAsset("AsyncPhysicsInputComponent")]
    public class UAsyncPhysicsInputComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}