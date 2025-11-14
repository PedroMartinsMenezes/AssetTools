namespace AssetTool
{
    [JsonAsset("AppleARKitTimecodeProvider")]
    public class UAppleARKitTimecodeProvider : UTimecodeProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}