namespace AssetTool
{
    [JsonAsset("LightingBuildInfo")]
    public class ULightingBuildInfo : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}