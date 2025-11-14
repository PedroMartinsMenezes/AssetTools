namespace AssetTool
{
    [JsonAsset("LightmassPortalComponent")]
    public class ULightmassPortalComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}