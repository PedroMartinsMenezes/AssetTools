namespace AssetTool
{
    [JsonAsset("SkinnedMeshComponent")]
    public class USkinnedMeshComponent : UMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}