namespace AssetTool
{
    [JsonAsset("VertexDeltaModelVizSettings")]
    public class UVertexDeltaModelVizSettings : UMLDeformerGeomCacheVizSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}