namespace AssetTool
{
    [JsonAsset("GraphElement")]
    public class UGraphElement : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}