namespace AssetTool
{
    [JsonAsset("InstancedActorsRepresentationSubsystem")]
    public class UInstancedActorsRepresentationSubsystem : UMassRepresentationSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}