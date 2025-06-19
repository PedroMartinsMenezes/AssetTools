namespace AssetTool
{
    [JsonAsset("VertexDeltaModelVizSettings")]
    public class UVertexDeltaModelVizSettings : UMLDeformerGeomCacheVizSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}