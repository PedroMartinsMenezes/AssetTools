namespace AssetTool
{
    [JsonAsset("EdGraph")]
    public class UEdGraph : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}