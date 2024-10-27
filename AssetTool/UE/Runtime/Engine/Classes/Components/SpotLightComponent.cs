namespace AssetTool
{
    [JsonAsset("SpotLightComponent")]
    public class USpotLightComponent : UPointLightComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}