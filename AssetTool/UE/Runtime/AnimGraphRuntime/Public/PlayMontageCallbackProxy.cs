namespace AssetTool
{
    [JsonAsset("PlayMontageCallbackProxy")]
    public class UPlayMontageCallbackProxy : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}