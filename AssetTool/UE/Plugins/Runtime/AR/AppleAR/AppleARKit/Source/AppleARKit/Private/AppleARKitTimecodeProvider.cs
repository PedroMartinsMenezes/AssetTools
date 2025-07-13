namespace AssetTool
{
    [JsonAsset("AppleARKitTimecodeProvider")]
    public class UAppleARKitTimecodeProvider : UTimecodeProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}