namespace AssetTool
{
    [JsonAsset("BTTaskNode")]
    public class UBTTaskNode : UBTNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}