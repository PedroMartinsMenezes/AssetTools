namespace AssetTool
{
    [JsonAsset("DebugSkelMeshComponent")]
    public class UDebugSkelMeshComponent : USkeletalMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}