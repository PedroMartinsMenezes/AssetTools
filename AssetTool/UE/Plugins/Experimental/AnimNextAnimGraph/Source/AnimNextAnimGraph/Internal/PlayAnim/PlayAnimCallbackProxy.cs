namespace AssetTool
{
    [JsonAsset("PlayAnimCallbackProxy")]
    public class UPlayAnimCallbackProxy : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}