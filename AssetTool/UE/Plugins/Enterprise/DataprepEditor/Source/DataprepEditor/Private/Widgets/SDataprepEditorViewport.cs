namespace AssetTool
{
    [JsonAsset("CustomStaticMeshComponent")]
    public class UCustomStaticMeshComponent : UStaticMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}