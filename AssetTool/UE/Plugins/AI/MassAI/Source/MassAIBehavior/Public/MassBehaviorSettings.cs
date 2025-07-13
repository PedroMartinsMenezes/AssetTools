namespace AssetTool
{
    [JsonAsset("MassBehaviorSettings")]
    public class UMassBehaviorSettings : UMassModuleSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}