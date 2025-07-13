namespace AssetTool
{
    [JsonAsset("BoolChannelKeyProxy")]
    public class UBoolChannelKeyProxy : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}