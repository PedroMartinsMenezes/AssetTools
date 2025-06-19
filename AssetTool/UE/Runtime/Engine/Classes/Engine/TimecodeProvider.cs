namespace AssetTool
{
    [JsonAsset("TimecodeProvider")]
    public class UTimecodeProvider : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}