namespace AssetTool
{
    [JsonAsset("SkyLightComponent")]
    public class USkyLightComponent : ULightComponentBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}