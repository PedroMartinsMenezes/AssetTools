namespace AssetTool
{
    [JsonAsset("VertexDeltaModelVizSettings")]
    public class UVertexDeltaModelVizSettings : UMLDeformerGeomCacheVizSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}