namespace AssetTool
{
    [JsonAsset("EdGraph")]
    public class UEdGraph : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}