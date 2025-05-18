namespace AssetTool
{
    [JsonAsset("CustomStaticMeshComponent")]
    public class UCustomStaticMeshComponent : UStaticMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}