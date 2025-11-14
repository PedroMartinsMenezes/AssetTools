namespace AssetTool
{
    [JsonAsset("CustomMeshComponent")]
    public class UCustomMeshComponent : UMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}