namespace AssetTool
{
    [JsonAsset("RuntimeOptionsBase")]
    public class URuntimeOptionsBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}