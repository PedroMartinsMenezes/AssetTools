namespace AssetTool
{
    [JsonAsset("CustomStaticMeshComponent")]
    public class UCustomStaticMeshComponent : UStaticMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}