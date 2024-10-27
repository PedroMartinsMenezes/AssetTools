namespace AssetTool
{
    [JsonAsset("SkinnedMeshComponent")]
    public class USkinnedMeshComponent : UMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}