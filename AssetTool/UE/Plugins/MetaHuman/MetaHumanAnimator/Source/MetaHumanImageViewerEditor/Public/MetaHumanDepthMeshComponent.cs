namespace AssetTool
{
    [JsonAsset("MetaHumanDepthMeshComponent")]
    public class UMetaHumanDepthMeshComponent : UProceduralMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}