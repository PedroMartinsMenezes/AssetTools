namespace AssetTool
{
    [JsonAsset("GraphElement")]
    public class UGraphElement : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}