namespace AssetTool
{
    [JsonAsset("LandscapeGizmoRenderComponent")]
    public class ULandscapeGizmoRenderComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}