namespace AssetTool
{
    [JsonAsset("RejoinCheck")]
    public class URejoinCheck : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}