namespace AssetTool
{
    [JsonAsset("LandscapeHeightfieldCollisionComponent")]
    public class ULandscapeHeightfieldCollisionComponent : UPrimitiveComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}