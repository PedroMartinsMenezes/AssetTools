namespace AssetTool
{
    [JsonAsset("LyraGameplayRpcRegistrationComponent")]
    public class ULyraGameplayRpcRegistrationComponent : UExternalRpcRegistrationComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}