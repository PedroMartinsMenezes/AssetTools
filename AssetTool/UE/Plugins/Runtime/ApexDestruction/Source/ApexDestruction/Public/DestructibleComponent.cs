namespace AssetTool
{
    [JsonAsset("DestructibleComponent")]
    public class UDestructibleComponent : USkinnedMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}