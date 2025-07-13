namespace AssetTool
{
    [JsonAsset("PlayAnimCallbackProxy")]
    public class UPlayAnimCallbackProxy : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}