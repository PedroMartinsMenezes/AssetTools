namespace AssetTool
{
    [JsonAsset("PlayMontageCallbackProxy")]
    public class UPlayMontageCallbackProxy : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}