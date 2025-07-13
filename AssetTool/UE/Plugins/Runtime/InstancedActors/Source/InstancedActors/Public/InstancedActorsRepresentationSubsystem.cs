namespace AssetTool
{
    [JsonAsset("InstancedActorsRepresentationSubsystem")]
    public class UInstancedActorsRepresentationSubsystem : UMassRepresentationSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}