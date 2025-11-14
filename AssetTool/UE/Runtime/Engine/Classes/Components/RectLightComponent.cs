namespace AssetTool
{
    [JsonAsset("RectLightComponent")]
    public class URectLightComponent : ULocalLightComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}