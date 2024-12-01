namespace AssetTool
{
    [JsonAsset("LandscapeMeshCollisionComponent")]
    public class ULandscapeMeshCollisionComponent : ULandscapeHeightfieldCollisionComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}