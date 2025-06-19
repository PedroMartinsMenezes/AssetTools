namespace AssetTool
{
    [JsonAsset("UserDefinedEnum")]
    public class UUserDefinedEnum : UEnum
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}