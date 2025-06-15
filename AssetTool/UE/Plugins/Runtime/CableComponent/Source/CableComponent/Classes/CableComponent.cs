namespace AssetTool
{
    [JsonAsset("CableComponent")]
    public class UCableComponent : UMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}