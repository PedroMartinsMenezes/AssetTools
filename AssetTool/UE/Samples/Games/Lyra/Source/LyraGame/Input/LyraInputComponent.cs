namespace AssetTool
{
    [JsonAsset("LyraInputComponent")]
    public class ULyraInputComponent : UEnhancedInputComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}