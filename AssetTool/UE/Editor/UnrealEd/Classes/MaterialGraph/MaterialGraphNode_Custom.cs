namespace AssetTool
{
    [JsonAsset("MaterialGraphNode_Custom")]
    public class UMaterialGraphNode_Custom : UMaterialGraphNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}