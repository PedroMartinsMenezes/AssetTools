namespace AssetTool
{
    [JsonAsset("SoundCueGraphSchema")]
    public class USoundCueGraphSchema : UEdGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}