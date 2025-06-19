namespace AssetTool
{
    [JsonAsset("DestructibleComponent")]
    public class UDestructibleComponent : USkinnedMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}