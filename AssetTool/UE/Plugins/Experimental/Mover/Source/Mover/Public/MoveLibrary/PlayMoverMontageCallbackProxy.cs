namespace AssetTool
{
    [JsonAsset("PlayMoverMontageCallbackProxy")]
    public class UPlayMoverMontageCallbackProxy : UPlayMontageCallbackProxy
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}