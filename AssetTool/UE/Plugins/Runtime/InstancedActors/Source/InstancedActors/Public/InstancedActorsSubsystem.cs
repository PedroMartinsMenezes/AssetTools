namespace AssetTool
{
    [JsonAsset("InstancedActorsSubsystem")]
    public class UInstancedActorsSubsystem : UTickableWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}