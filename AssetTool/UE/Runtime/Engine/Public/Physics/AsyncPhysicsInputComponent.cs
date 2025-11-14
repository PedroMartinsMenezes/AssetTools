namespace AssetTool
{
    [JsonAsset("AsyncPhysicsInputComponent")]
    public class UAsyncPhysicsInputComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}