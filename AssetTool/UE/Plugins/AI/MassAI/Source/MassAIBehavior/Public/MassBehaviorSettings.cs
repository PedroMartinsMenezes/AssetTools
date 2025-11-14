namespace AssetTool
{
    [JsonAsset("MassBehaviorSettings")]
    public class UMassBehaviorSettings : UMassModuleSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}