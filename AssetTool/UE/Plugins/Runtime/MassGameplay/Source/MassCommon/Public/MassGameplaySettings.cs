namespace AssetTool
{
    [JsonAsset("MassGameplaySettings")]
    public class UMassGameplaySettings : UMassModuleSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}