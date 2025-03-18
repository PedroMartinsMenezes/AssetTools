namespace AssetTool
{
    [JsonAsset("DestructibleComponent")]
    public class UDestructibleComponent : USkinnedMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}