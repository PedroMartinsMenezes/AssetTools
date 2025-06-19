namespace AssetTool
{
    [JsonAsset("DebugSkelMeshComponent")]
    public class UDebugSkelMeshComponent : USkeletalMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}