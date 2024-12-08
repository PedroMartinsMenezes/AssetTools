namespace AssetTool
{
    [JsonAsset("RuntimeOptionsBase")]
    public class URuntimeOptionsBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}