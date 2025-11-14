namespace AssetTool
{
    [JsonAsset("RuntimeOptionsBase")]
    public class URuntimeOptionsBase : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}