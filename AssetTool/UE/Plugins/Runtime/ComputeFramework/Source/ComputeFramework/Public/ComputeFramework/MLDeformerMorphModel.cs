namespace AssetTool
{
    [JsonAsset("MLDeformerMorphModel")]
    public class UMLDeformerMorphModel : UMLDeformerGeomCacheModel
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}