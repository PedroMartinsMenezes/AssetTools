namespace AssetTool
{
    [JsonAsset("MassGameplaySettings")]
    public class UMassGameplaySettings : UMassModuleSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}