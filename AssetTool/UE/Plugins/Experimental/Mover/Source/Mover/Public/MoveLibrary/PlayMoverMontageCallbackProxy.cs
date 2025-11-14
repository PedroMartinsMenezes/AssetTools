namespace AssetTool
{
    [JsonAsset("PlayMoverMontageCallbackProxy")]
    public class UPlayMoverMontageCallbackProxy : UPlayMontageCallbackProxy
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}