namespace AssetTool
{
    [JsonAsset("MassActorSubsystem")]
    public class UMassActorSubsystem : UMassSubsystemBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}