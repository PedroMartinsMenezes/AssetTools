namespace AssetTool
{
    [JsonAsset("MassCrowdSettings")]
    public class UMassCrowdSettings : UMassModuleSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}