namespace AssetTool
{
    [JsonAsset("SpotLightComponent")]
    public class USpotLightComponent : UPointLightComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}