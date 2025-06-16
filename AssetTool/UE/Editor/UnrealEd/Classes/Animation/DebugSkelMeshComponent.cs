namespace AssetTool
{
    [JsonAsset("DebugSkelMeshComponent")]
    public class UDebugSkelMeshComponent : USkeletalMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}