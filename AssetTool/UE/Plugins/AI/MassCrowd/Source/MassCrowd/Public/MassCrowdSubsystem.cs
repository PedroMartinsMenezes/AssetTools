namespace AssetTool
{
    [JsonAsset("MassCrowdSubsystem")]
    public class UMassCrowdSubsystem : UMassSubsystemBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}