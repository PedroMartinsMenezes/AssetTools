namespace AssetTool
{
    [JsonAsset("ProceduralMeshComponent")]
    public class UProceduralMeshComponent : UMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}