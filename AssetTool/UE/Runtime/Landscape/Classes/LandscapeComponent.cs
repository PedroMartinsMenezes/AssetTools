namespace AssetTool
{
    [JsonAsset("LandscapeLODStreamingProxy_DEPRECATED")]
    public class ULandscapeLODStreamingProxy_DEPRECATED : UStreamableRenderAsset
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LandscapeComponent")]
    public class ULandscapeComponent : UPrimitiveComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}