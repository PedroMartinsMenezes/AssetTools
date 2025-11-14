namespace AssetTool
{
    [JsonAsset("XRScribeDeveloperSettings")]
    public class UXRScribeDeveloperSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}