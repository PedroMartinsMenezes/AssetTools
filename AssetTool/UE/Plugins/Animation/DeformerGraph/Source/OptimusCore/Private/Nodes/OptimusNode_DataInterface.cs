namespace AssetTool
{
    [JsonAsset("OptimusNode_DataInterface")]
    public class UOptimusNode_DataInterface : UOptimusNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}