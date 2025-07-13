namespace AssetTool
{
    [JsonAsset("InstancedActorsSubsystem")]
    public class UInstancedActorsSubsystem : UTickableWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}