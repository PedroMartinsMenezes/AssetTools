namespace AssetTool
{
    [JsonAsset("XRScribeDeveloperSettings")]
    public class UXRScribeDeveloperSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}