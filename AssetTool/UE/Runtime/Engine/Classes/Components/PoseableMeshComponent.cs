namespace AssetTool
{
    [JsonAsset("PoseableMeshComponent")]
    public class UPoseableMeshComponent : USkinnedMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}