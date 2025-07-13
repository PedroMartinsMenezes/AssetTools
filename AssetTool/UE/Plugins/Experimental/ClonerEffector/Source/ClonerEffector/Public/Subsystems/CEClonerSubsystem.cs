namespace AssetTool
{
    [JsonAsset("CEClonerSubsystem")]
    public class UCEClonerSubsystem : UEngineSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}