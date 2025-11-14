namespace AssetTool
{
    [JsonAsset("SoundCueGraphSchema")]
    public class USoundCueGraphSchema : UEdGraphSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}