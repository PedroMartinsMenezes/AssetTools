namespace AssetTool
{
    [JsonAsset("TG_EdGraphSchema")]
    public class UTG_EdGraphSchema : UEdGraphSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}