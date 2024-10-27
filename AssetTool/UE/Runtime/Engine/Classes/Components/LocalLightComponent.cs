namespace AssetTool
{
    [JsonAsset("LocalLightComponent")]
    public class ULocalLightComponent : ULightComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}