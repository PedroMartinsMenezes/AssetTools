namespace AssetTool
{
    [JsonAsset("MLDeformerMorphModelInstance")]
    public class UMLDeformerMorphModelInstance : UMLDeformerModelInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}