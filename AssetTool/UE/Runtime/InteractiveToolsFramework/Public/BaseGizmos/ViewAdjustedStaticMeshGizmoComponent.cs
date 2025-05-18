namespace AssetTool
{
    [JsonAsset("ViewAdjustedStaticMeshGizmoComponent")]
    public class UViewAdjustedStaticMeshGizmoComponent : UStaticMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}