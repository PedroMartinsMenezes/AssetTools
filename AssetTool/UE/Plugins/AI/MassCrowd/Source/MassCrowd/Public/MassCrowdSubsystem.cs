namespace AssetTool
{
    [JsonAsset("MassCrowdSubsystem")]
    public class UMassCrowdSubsystem : UMassSubsystemBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}