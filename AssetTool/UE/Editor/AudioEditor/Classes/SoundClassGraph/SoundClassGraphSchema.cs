namespace AssetTool
{
    [JsonAsset("SoundClassGraphSchema")]
    public class USoundClassGraphSchema : UEdGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}