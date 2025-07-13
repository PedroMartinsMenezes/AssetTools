namespace AssetTool
{
    [JsonAsset("LandscapePatchComponent")]
    public class ULandscapePatchComponent : USceneComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}