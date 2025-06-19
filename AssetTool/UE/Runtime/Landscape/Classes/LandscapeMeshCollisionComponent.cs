namespace AssetTool
{
    [JsonAsset("LandscapeMeshCollisionComponent")]
    public class ULandscapeMeshCollisionComponent : ULandscapeHeightfieldCollisionComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}