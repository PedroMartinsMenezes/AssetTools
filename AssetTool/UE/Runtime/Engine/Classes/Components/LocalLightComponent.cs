namespace AssetTool
{
    [JsonAsset("LocalLightComponent")]
    public class ULocalLightComponent : ULightComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}