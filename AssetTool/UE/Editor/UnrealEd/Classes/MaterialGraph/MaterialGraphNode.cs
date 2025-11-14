namespace AssetTool
{
    [JsonAsset("MaterialGraphNode")]
    public class UMaterialGraphNode : UMaterialGraphNode_Base
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}