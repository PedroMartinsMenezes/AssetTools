namespace AssetTool
{
    [JsonAsset("BlueprintFactory")]
    public class UBlueprintFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}