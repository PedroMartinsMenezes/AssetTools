namespace AssetTool
{
    [JsonAsset("CommonUIVisibilitySubsystem")]
    public class UCommonUIVisibilitySubsystem : ULocalPlayerSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}