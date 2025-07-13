namespace AssetTool
{
    [JsonAsset("MediaProfile")]
    public class UMediaProfile : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}