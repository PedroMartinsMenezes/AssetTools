namespace AssetTool
{
    [JsonAsset("MassCrowdSettings")]
    public class UMassCrowdSettings : UMassModuleSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}