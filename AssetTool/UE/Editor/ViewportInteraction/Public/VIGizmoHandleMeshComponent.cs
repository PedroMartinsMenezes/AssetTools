namespace AssetTool
{
    [JsonAsset("GizmoHandleMeshComponent")]
    public class UGizmoHandleMeshComponent : UStaticMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}