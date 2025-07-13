namespace AssetTool
{
    [JsonAsset("MassActorSubsystem")]
    public class UMassActorSubsystem : UMassSubsystemBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}