namespace AssetTool
{
    [JsonAsset("EdGraphSchema")]
    public class UEdGraphSchema : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}