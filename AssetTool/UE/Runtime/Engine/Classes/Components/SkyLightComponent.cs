namespace AssetTool
{
    [JsonAsset("SkyLightComponent")]
    public class USkyLightComponent : ULightComponentBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}