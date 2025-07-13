namespace AssetTool
{
    [JsonAsset("GraphVertex")]
    public class UGraphVertex : UGraphElement
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}