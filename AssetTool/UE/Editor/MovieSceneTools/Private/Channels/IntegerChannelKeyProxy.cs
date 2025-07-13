namespace AssetTool
{
    [JsonAsset("IntegerChannelKeyProxy")]
    public class UIntegerChannelKeyProxy : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}