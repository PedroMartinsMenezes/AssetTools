namespace AssetTool
{
    [JsonAsset("GizmoHandleMeshComponent")]
    public class UGizmoHandleMeshComponent : UStaticMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}