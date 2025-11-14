namespace AssetTool
{
    [JsonAsset("MassEntitySettings")]
    public class UMassEntitySettings : UMassModuleSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}