namespace AssetTool
{
    [JsonAsset("LightmassPortalComponent")]
    public class ULightmassPortalComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}