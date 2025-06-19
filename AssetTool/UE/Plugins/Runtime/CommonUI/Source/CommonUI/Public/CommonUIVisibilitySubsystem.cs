namespace AssetTool
{
    [JsonAsset("CommonUIVisibilitySubsystem")]
    public class UCommonUIVisibilitySubsystem : ULocalPlayerSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}