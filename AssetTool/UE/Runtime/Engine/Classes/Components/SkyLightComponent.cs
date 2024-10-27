namespace AssetTool
{
    [JsonAsset("SkyLightComponent")]
    public class USkyLightComponent : ULightComponentBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}