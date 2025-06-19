namespace AssetTool
{
    [JsonAsset("MLDeformerMorphModel")]
    public class UMLDeformerMorphModel : UMLDeformerGeomCacheModel
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}