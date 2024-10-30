namespace AssetTool
{
    [JsonAsset("BlueprintFactory")]
    public class UBlueprintFactory : UFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}