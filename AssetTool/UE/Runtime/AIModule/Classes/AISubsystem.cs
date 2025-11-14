namespace AssetTool
{
    [JsonAsset("AISubsystem")]
    public class UAISubsystem : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}