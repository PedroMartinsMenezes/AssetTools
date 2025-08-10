namespace AssetTool
{
    [JsonAsset("MetaHumanDepthMeshComponent")]
    public class UMetaHumanDepthMeshComponent : UProceduralMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}