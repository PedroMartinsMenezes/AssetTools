namespace AssetTool
{
    [JsonAsset("MLDeformerMorphModelVizSettings")]
    public class UMLDeformerMorphModelVizSettings : UMLDeformerGeomCacheVizSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}