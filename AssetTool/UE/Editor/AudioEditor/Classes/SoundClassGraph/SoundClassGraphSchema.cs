namespace AssetTool
{
    [JsonAsset("SoundClassGraphSchema")]
    public class USoundClassGraphSchema : UEdGraphSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}