namespace AssetTool
{
    [JsonAsset("LandscapeGizmoRenderComponent")]
    public class ULandscapeGizmoRenderComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}