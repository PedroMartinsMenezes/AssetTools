namespace AssetTool
{
    [JsonAsset("LandscapeMeshCollisionComponent")]
    public class ULandscapeMeshCollisionComponent : ULandscapeHeightfieldCollisionComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}