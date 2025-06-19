namespace AssetTool
{
    [JsonAsset("ViewAdjustedStaticMeshGizmoComponent")]
    public class UViewAdjustedStaticMeshGizmoComponent : UStaticMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}