namespace AssetTool
{
    [JsonAsset("TimecodeProvider")]
    public class UTimecodeProvider : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}