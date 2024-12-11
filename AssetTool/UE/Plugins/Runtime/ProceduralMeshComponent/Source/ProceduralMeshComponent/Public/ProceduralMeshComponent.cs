namespace AssetTool
{
    [JsonAsset("ProceduralMeshComponent")]
    public class UProceduralMeshComponent : UMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}