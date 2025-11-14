namespace AssetTool
{
    [JsonAsset("BTTaskNode")]
    public class UBTTaskNode : UBTNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}