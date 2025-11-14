namespace AssetTool
{
    [JsonAsset("ViewAdjustedStaticMeshGizmoComponent")]
    public class UViewAdjustedStaticMeshGizmoComponent : UStaticMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}