namespace AssetTool
{
    [JsonAsset("MLDeformerMorphModelVizSettings")]
    public class UMLDeformerMorphModelVizSettings : UMLDeformerGeomCacheVizSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}