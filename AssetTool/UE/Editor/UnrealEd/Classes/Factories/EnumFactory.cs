namespace AssetTool
{
    [JsonAsset("EnumFactory")]
    public class UEnumFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}