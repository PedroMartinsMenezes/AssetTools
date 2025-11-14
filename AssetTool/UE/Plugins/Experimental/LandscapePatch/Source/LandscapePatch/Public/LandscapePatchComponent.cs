namespace AssetTool
{
    [JsonAsset("LandscapePatchComponent")]
    public class ULandscapePatchComponent : USceneComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}