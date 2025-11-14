namespace AssetTool
{
    [JsonAsset("SkinnedMeshComponent")]
    public class USkinnedMeshComponent : UMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}