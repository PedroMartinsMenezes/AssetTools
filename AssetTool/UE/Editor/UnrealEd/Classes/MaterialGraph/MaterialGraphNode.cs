namespace AssetTool
{
    [JsonAsset("MaterialGraphNode")]
    public class UMaterialGraphNode : UMaterialGraphNode_Base
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}