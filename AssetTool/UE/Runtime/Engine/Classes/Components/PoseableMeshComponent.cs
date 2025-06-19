namespace AssetTool
{
    [JsonAsset("PoseableMeshComponent")]
    public class UPoseableMeshComponent : USkinnedMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}