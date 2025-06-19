namespace AssetTool
{
    [JsonAsset("RectLightComponent")]
    public class URectLightComponent : ULocalLightComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}