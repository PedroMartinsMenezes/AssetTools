namespace AssetTool
{
    [JsonAsset("SpotLightComponent")]
    public class USpotLightComponent : UPointLightComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}