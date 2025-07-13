namespace AssetTool
{
    [JsonAsset("TypedElementRegistry")]
    public class UTypedElementRegistry : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}