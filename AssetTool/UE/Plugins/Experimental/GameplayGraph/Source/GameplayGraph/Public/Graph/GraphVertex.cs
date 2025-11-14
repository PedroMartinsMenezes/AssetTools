namespace AssetTool
{
    [JsonAsset("GraphVertex")]
    public class UGraphVertex : UGraphElement
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}