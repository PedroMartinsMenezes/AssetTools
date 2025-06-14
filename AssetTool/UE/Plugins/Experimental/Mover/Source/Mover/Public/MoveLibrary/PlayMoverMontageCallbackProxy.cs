namespace AssetTool
{
    [JsonAsset("PlayMoverMontageCallbackProxy")]
    public class UPlayMoverMontageCallbackProxy : UPlayMontageCallbackProxy
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}