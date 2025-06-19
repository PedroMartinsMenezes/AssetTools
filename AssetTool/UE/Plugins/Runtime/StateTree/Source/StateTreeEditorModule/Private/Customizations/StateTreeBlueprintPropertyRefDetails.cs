namespace AssetTool
{
    [JsonAsset("StateTreePropertyRefSchema")]
    public class UStateTreePropertyRefSchema : UEdGraphSchema_K2
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}