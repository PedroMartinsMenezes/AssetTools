namespace AssetTool
{
    [JsonAsset("TypedElementCommonActions")]
    public class UTypedElementCommonActions : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}