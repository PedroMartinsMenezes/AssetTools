namespace AssetTool
{
    [JsonAsset("MLDeformerAsset")]
    public class UMLDeformerAsset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}