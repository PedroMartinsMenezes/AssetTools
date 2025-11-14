namespace AssetTool
{
    [JsonAsset("PoseableMeshComponent")]
    public class UPoseableMeshComponent : USkinnedMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}