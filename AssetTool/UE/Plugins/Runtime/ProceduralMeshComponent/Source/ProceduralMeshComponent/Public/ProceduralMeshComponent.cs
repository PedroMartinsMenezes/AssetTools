namespace AssetTool
{
    [JsonAsset("ProceduralMeshComponent")]
    public class UProceduralMeshComponent : UMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}