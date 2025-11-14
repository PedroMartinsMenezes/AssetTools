namespace AssetTool
{
    [JsonAsset("LyraInputComponent")]
    public class ULyraInputComponent : UEnhancedInputComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}