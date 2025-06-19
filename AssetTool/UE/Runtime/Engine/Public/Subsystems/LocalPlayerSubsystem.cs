namespace AssetTool
{
    [JsonAsset("LocalPlayerSubsystem")]
    public class ULocalPlayerSubsystem : USubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}