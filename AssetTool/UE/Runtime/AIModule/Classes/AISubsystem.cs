namespace AssetTool
{
    [JsonAsset("AISubsystem")]
    public class UAISubsystem : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}