namespace AssetTool
{
    [JsonAsset("MLDeformerMorphModelVizSettings")]
    public class UMLDeformerMorphModelVizSettings : UMLDeformerGeomCacheVizSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}