namespace AssetTool
{
    [JsonAsset("LocalLightComponent")]
    public class ULocalLightComponent : ULightComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}