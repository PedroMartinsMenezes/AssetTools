namespace AssetTool
{
    [JsonAsset("LocationServices")]
    public class ULocationServices : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}