namespace AssetTool
{
    [JsonAsset("RectLightComponent")]
    public class URectLightComponent : ULocalLightComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}